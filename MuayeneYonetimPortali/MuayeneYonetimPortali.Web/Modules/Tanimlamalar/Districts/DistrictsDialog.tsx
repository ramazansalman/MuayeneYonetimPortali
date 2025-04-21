import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DistrictsForm, DistrictsRow, DistrictsService } from '../../ServerTypes/Tanimlamalar';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DistrictsDialog')
export class DistrictsDialog extends EntityDialog<DistrictsRow, any> {
    protected getFormKey() { return DistrictsForm.formKey; }
    protected getRowDefinition() { return DistrictsRow; }
    protected getService() { return DistrictsService.baseUrl; }

    protected form = new DistrictsForm(this.idPrefix);
}