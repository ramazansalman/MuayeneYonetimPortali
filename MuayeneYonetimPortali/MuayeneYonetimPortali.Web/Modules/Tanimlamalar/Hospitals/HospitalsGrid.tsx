import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { HospitalsColumns, HospitalsRow, HospitalsService } from '../../ServerTypes/Tanimlamalar';
import { HospitalsDialog } from './HospitalsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.HospitalsGrid')
export class HospitalsGrid extends EntityGrid<HospitalsRow> {
    protected getColumnsKey() { return HospitalsColumns.columnsKey; }
    protected getDialogType() { return HospitalsDialog; }
    protected getRowDefinition() { return HospitalsRow; }
    protected getService() { return HospitalsService.baseUrl; }
}