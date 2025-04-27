import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DrugsColumns, DrugsRow, DrugsService } from '../../ServerTypes/Tanimlamalar';
import { DrugsDialog } from './DrugsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DrugsGrid')
export class DrugsGrid extends EntityGrid<DrugsRow> {
    protected getColumnsKey() { return DrugsColumns.columnsKey; }
    protected getDialogType() { return DrugsDialog; }
    protected getRowDefinition() { return DrugsRow; }
    protected getService() { return DrugsService.baseUrl; }
}