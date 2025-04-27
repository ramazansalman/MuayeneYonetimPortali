import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PrescriptionsColumns, PrescriptionsRow, PrescriptionsService } from '../../ServerTypes/Prescriptions';
import { PrescriptionsDialog } from './PrescriptionsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Prescriptions.PrescriptionsGrid')
export class PrescriptionsGrid extends EntityGrid<PrescriptionsRow> {
    protected getColumnsKey() { return PrescriptionsColumns.columnsKey; }
    protected getDialogType() { return PrescriptionsDialog; }
    protected getRowDefinition() { return PrescriptionsRow; }
    protected getService() { return PrescriptionsService.baseUrl; }
}