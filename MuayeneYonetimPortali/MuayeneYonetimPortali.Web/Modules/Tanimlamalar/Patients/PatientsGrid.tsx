import { Decorators, EntityGrid, GridRowSelectionMixin, localText, text, Toastr } from '@serenity-is/corelib';
import { PatientsColumns, PatientsRow, PatientsService } from '../../ServerTypes/Tanimlamalar';
import { PatientsDialog } from './PatientsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.PatientsGrid')
export class PatientsGrid extends EntityGrid<PatientsRow> {
    protected getColumnsKey() { return PatientsColumns.columnsKey; }
    protected getDialogType() { return PatientsDialog; }
    protected getRowDefinition() { return PatientsRow; }
    protected getService() { return PatientsService.baseUrl; }
    private rowSelection: GridRowSelectionMixin;
    protected createToolbarExtensions() {
        super.createToolbarExtensions();
   
        this.rowSelection = new GridRowSelectionMixin(this, { });
    }
   
    protected getColumns() {
        var columns = super.getColumns();
   
        var sc = GridRowSelectionMixin.createSelectColumn(() => this.rowSelection);
        sc.width = 30;
        columns.splice(0, 0, sc);
        return columns;
    }

    protected override getButtons() {

        var self = this;

        var buttons = super.getButtons();

        buttons.push({
            cssClass: "add-button icon-tool-button",
            title: localText("Toplu Sil"),
            icon: "fa-trash-alt text-red",
            onClick: e => {

                let secilen = this.rowSelection.getSelectedAsInt32();
                //alert(secilen);
                secilen.forEach(element => {
                    PatientsService.Delete({EntityId:element
                    });
                });
        }});

        return buttons;
    }
}