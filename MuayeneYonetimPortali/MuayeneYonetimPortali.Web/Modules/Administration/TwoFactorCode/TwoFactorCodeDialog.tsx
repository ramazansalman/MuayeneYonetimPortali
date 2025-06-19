import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TwoFactorCodeForm, TwoFactorCodeRow, TwoFactorCodeService } from '../../ServerTypes/Administration';

@Decorators.registerClass('MuayeneYonetimPortali.Administration.TwoFactorCodeDialog')
export class TwoFactorCodeDialog extends EntityDialog<TwoFactorCodeRow, any> {
    protected getFormKey() { return TwoFactorCodeForm.formKey; }
    protected getRowDefinition() { return TwoFactorCodeRow; }
    protected getService() { return TwoFactorCodeService.baseUrl; }

    protected form = new TwoFactorCodeForm(this.idPrefix);
}