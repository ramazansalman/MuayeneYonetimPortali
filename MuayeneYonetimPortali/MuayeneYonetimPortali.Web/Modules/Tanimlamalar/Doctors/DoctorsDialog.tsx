import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DoctorsForm, DoctorsRow, DoctorsService } from '../../ServerTypes/Tanimlamalar';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DoctorsDialog')
export class DoctorsDialog extends EntityDialog<DoctorsRow, any> {
    protected getFormKey() { return DoctorsForm.formKey; }
    protected getRowDefinition() { return DoctorsRow; }
    protected getService() { return DoctorsService.baseUrl; }

    protected form = new DoctorsForm(this.idPrefix);
}