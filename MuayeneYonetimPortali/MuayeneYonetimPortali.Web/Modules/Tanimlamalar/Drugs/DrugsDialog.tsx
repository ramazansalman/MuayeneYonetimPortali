import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DrugsForm, DrugsRow, DrugsService } from '../../ServerTypes/Tanimlamalar';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DrugsDialog')
export class DrugsDialog extends EntityDialog<DrugsRow, any> {
    protected getFormKey() { return DrugsForm.formKey; }
    protected getRowDefinition() { return DrugsRow; }
    protected getService() { return DrugsService.baseUrl; }

    protected form = new DrugsForm(this.idPrefix);
}