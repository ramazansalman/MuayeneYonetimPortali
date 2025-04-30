import { Decorators, EntityGrid, postToService, localText } from '@serenity-is/corelib';
import { PrescriptionsColumns, PrescriptionsRow, PrescriptionsService } from '../../ServerTypes/Prescriptions';
import { PrescriptionsDialog } from './PrescriptionsDialog';
import { Column } from '@serenity-is/sleekgrid';
declare var Q: any;
declare var $: any;

@Decorators.registerClass('MuayeneYonetimPortali.Prescriptions.PrescriptionsGrid')
export class PrescriptionsGrid extends EntityGrid<PrescriptionsRow> {
    protected getColumnsKey() { return PrescriptionsColumns.columnsKey; }
    protected getDialogType() { return PrescriptionsDialog; }
    protected getRowDefinition() { return PrescriptionsRow; }
    protected getService() { return PrescriptionsService.baseUrl; }

    protected getColumns(): Column[] {
        const columns = super.getColumns();

        columns.splice(0, 0, {
            field: 'Makbuz',
            name: '',
            format: () => {
                return (
                    `<a class="inline-action makbuz" title="${localText("Site.Buttons.Makbuz") ?? "Makbuz"}">
                        <i class="fa fa-print text-blue"></i>
                    </a>`
                );
            },
            width: 35
        });

        return columns;
    }

    protected onClick(e: Event, row: number, cell: number): void {
        super.onClick(e, row, cell);

        const item = this.itemAt(row);
        const target = $(e.target);

        if (target.hasClass('makbuz') || target.closest('a').hasClass('makbuz')) {
            e.preventDefault();

            postToService({
                service: "Prescriptions/Prescriptions/Makbuz",
                request: { EntityId: item.PrescriptionId },
                target: "_blank"
            });
        }
    }
}
