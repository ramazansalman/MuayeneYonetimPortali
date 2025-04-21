import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DepartmentsColumns, DepartmentsRow, DepartmentsService } from '../../ServerTypes/Tanimlamalar';
import { DepartmentsDialog } from './DepartmentsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DepartmentsGrid')
export class DepartmentsGrid extends EntityGrid<DepartmentsRow> {
    protected getColumnsKey() { return DepartmentsColumns.columnsKey; }
    protected getDialogType() { return DepartmentsDialog; }
    protected getRowDefinition() { return DepartmentsRow; }
    protected getService() { return DepartmentsService.baseUrl; }
}