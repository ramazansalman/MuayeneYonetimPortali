import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CityColumns, CityRow, CityService } from '../../ServerTypes/Tanimlamalar';
import { CityDialog } from './CityDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.CityGrid')
export class CityGrid extends EntityGrid<CityRow> {
    protected getColumnsKey() { return CityColumns.columnsKey; }
    protected getDialogType() { return CityDialog; }
    protected getRowDefinition() { return CityRow; }
    protected getService() { return CityService.baseUrl; }
}