import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExaminationsForm, ExaminationsRow, ExaminationsService } from '../../ServerTypes/Examinations';

@Decorators.registerClass('MuayeneYonetimPortali.Examinations.ExaminationsDialog')
export class ExaminationsDialog extends EntityDialog<ExaminationsRow, any> {
    protected getFormKey() { return ExaminationsForm.formKey; }
    protected getRowDefinition() { return ExaminationsRow; }
    protected getService() { return ExaminationsService.baseUrl; }

    protected form = new ExaminationsForm(this.idPrefix);
}