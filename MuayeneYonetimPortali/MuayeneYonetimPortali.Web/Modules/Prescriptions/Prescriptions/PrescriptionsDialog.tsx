import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PrescriptionsForm, PrescriptionsRow, PrescriptionsService } from '../../ServerTypes/Prescriptions';

@Decorators.registerClass('MuayeneYonetimPortali.Prescriptions.PrescriptionsDialog')
export class PrescriptionsDialog extends EntityDialog<PrescriptionsRow, any> {
    protected getFormKey() { return PrescriptionsForm.formKey; }
    protected getRowDefinition() { return PrescriptionsRow; }
    protected getService() { return PrescriptionsService.baseUrl; }

    protected form = new PrescriptionsForm(this.idPrefix);
}