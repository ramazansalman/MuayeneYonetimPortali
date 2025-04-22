import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DoctorsColumns, DoctorsRow, DoctorsService } from '../../ServerTypes/Tanimlamalar';
import { DoctorsDialog } from './DoctorsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DoctorsGrid')
export class DoctorsGrid extends EntityGrid<DoctorsRow> {
    protected getColumnsKey() { return DoctorsColumns.columnsKey; }
    protected getDialogType() { return DoctorsDialog; }
    protected getRowDefinition() { return DoctorsRow; }
    protected getService() { return DoctorsService.baseUrl; }
}