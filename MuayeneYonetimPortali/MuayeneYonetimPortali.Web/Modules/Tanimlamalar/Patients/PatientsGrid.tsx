import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PatientsColumns, PatientsRow, PatientsService } from '../../ServerTypes/Tanimlamalar';
import { PatientsDialog } from './PatientsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.PatientsGrid')
export class PatientsGrid extends EntityGrid<PatientsRow> {
    protected getColumnsKey() { return PatientsColumns.columnsKey; }
    protected getDialogType() { return PatientsDialog; }
    protected getRowDefinition() { return PatientsRow; }
    protected getService() { return PatientsService.baseUrl; }
}