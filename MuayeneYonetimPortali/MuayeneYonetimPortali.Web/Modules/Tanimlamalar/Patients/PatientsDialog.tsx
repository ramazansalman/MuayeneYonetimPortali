import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PatientsForm, PatientsRow, PatientsService } from '../../ServerTypes/Tanimlamalar';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.PatientsDialog')
export class PatientsDialog extends EntityDialog<PatientsRow, any> {
    protected getFormKey() { return PatientsForm.formKey; }
    protected getRowDefinition() { return PatientsRow; }
    protected getService() { return PatientsService.baseUrl; }

    protected form = new PatientsForm(this.idPrefix);
}