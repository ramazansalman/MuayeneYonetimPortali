import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { HospitalsForm, HospitalsRow, HospitalsService } from '../../ServerTypes/Tanimlamalar';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.HospitalsDialog')
export class HospitalsDialog extends EntityDialog<HospitalsRow, any> {
    protected getFormKey() { return HospitalsForm.formKey; }
    protected getRowDefinition() { return HospitalsRow; }
    protected getService() { return HospitalsService.baseUrl; }

    protected form = new HospitalsForm(this.idPrefix);
}