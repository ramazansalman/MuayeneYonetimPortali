import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DepartmentsForm, DepartmentsRow, DepartmentsService } from '../../ServerTypes/Tanimlamalar';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DepartmentsDialog')
export class DepartmentsDialog extends EntityDialog<DepartmentsRow, any> {
    protected getFormKey() { return DepartmentsForm.formKey; }
    protected getRowDefinition() { return DepartmentsRow; }
    protected getService() { return DepartmentsService.baseUrl; }

    protected form = new DepartmentsForm(this.idPrefix);
}