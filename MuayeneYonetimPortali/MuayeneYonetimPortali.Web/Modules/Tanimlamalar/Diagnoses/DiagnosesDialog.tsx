import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DiagnosesForm, DiagnosesRow, DiagnosesService } from '../../ServerTypes/Tanimlamalar';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DiagnosesDialog')
export class DiagnosesDialog extends EntityDialog<DiagnosesRow, any> {
    protected getFormKey() { return DiagnosesForm.formKey; }
    protected getRowDefinition() { return DiagnosesRow; }
    protected getService() { return DiagnosesService.baseUrl; }

    protected form = new DiagnosesForm(this.idPrefix);
}