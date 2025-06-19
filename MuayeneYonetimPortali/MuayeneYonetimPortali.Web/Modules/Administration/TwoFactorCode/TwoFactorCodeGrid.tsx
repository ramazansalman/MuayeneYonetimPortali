import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TwoFactorCodeColumns, TwoFactorCodeRow, TwoFactorCodeService } from '../../ServerTypes/Administration';
import { TwoFactorCodeDialog } from './TwoFactorCodeDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Administration.TwoFactorCodeGrid')
export class TwoFactorCodeGrid extends EntityGrid<TwoFactorCodeRow> {
    protected getColumnsKey() { return TwoFactorCodeColumns.columnsKey; }
    protected getDialogType() { return TwoFactorCodeDialog; }
    protected getRowDefinition() { return TwoFactorCodeRow; }
    protected getService() { return TwoFactorCodeService.baseUrl; }
}