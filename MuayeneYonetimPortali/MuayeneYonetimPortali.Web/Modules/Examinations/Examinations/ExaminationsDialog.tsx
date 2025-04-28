import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExaminationsForm, ExaminationsRow, ExaminationsService } from '../../ServerTypes/Examinations';

@Decorators.registerClass('MuayeneYonetimPortali.Examinations.ExaminationsDialog')
export class ExaminationsDialog extends EntityDialog<ExaminationsRow, any> {
    protected getFormKey() { return ExaminationsForm.formKey; }
    protected getRowDefinition() { return ExaminationsRow; }
    protected getService() { return ExaminationsService.baseUrl; }

    protected form = new ExaminationsForm(this.idPrefix);

    loadEntityAndOpenDialog(initData: Partial<ExaminationsRow>) {
        this.loadEntity({} as any);
        this.dialogOpen();
    
        if (initData.AppointmentId != null)
            this.form.AppointmentId.value = initData.AppointmentId.toString();
    
        if (initData.DoctorId != null)
            this.form.DoctorId.value = initData.DoctorId.toString();
    
        if (initData.PatientId != null)
            this.form.PatientId.value = initData.PatientId.toString();
    
        if (initData.ExaminationDate != null)
            this.form.ExaminationDate.valueAsDate = new Date(initData.ExaminationDate);
    }
}