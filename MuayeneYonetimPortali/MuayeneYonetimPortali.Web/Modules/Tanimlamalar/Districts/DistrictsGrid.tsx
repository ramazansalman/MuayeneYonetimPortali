import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DistrictsColumns, DistrictsRow, DistrictsService } from '../../ServerTypes/Tanimlamalar';
import { DistrictsDialog } from './DistrictsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DistrictsGrid')
export class DistrictsGrid extends EntityGrid<DistrictsRow> {
    protected getColumnsKey() { return DistrictsColumns.columnsKey; }
    protected getDialogType() { return DistrictsDialog; }
    protected getRowDefinition() { return DistrictsRow; }
    protected getService() { return DistrictsService.baseUrl; }
}