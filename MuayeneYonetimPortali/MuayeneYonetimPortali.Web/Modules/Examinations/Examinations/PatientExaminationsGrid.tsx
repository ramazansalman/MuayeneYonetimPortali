import { Decorators, EntityGrid, SubDialogHelper } from '@serenity-is/corelib';
import { ExaminationsColumns, ExaminationsRow, ExaminationsService } from '../../ServerTypes/Examinations';
import { ExaminationsDialog } from './ExaminationsDialog';
import { Column } from '@serenity-is/sleekgrid';

const fld = ExaminationsRow.Fields;

@Decorators.registerClass('MuayeneYonetimPortali.Examinations.ExaminationsGrid')
export class PatientExaminationsGrid extends EntityGrid<ExaminationsRow> {
    protected getColumnsKey() { return ExaminationsColumns.columnsKey; }
    protected getDialogType() { return ExaminationsDialog; }
    protected getRowDefinition() { return ExaminationsRow; }
    protected getService() { return ExaminationsService.baseUrl; }

    protected getColumns(): Column[] {
        return super.getColumns().filter(x => x.field !== fld.PatientName);
    }

    protected initEntityDialog(itemType, dialog) {
        super.initEntityDialog(itemType, dialog);
        SubDialogHelper.cascade(dialog, this.domNode.closest('.ui-dialog') as HTMLElement);
    }

    declare private _patientID: number;

    get patientID() {
        return this._patientID;
    }

    set patientID(value: number) {
        if (this._patientID !== value) {
            this._patientID = value;
            this.setEquality(fld.PatientId, value);
            this.refresh();
            this.updateInterface();
        }
    }

    protected override getButtons() {
        var buttons = super.getButtons();
        var addButton = buttons.find(x => x.action === 'add');
        if (addButton)
            addButton.disabled = () => !this._patientID;
        return buttons;
    }

    protected addButtonClick() {
        if (!this.patientID)
            return;
        this.editItem({ PatientId: this._patientID });
    }
    
    protected getInitialTitle() {
        return null;
    }

        protected getGridCanLoad() {
        return super.getGridCanLoad() && !!this.patientID;
    }
}