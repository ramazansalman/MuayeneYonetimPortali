import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExaminationsForm, ExaminationsRow, ExaminationsService } from '../../ServerTypes/Examinations';
import { PrescriptionsDialog } from '../../Prescriptions/Prescriptions/PrescriptionsDialog';

declare var $: any;
@Decorators.registerClass('MuayeneYonetimPortali.Examinations.ExaminationsDialog')
export class ExaminationsDialog extends EntityDialog<ExaminationsRow, any> {
    protected getFormKey() { return ExaminationsForm.formKey; }
    protected getRowDefinition() { return ExaminationsRow; }
    protected getService() { return ExaminationsService.baseUrl; }

    protected form = new ExaminationsForm(this.idPrefix);

    private openExaminationDialog() {
        if (!this.isEditMode())
            return;

        const examinaton = this.entity!;
        const presDialog = new PrescriptionsDialog();
        presDialog.loadEntityAndOpenDialog({
            ExaminationId: examinaton.ExaminationId,
            DoctorId: examinaton.DoctorId,
            PatientId: examinaton.PatientId,
            PrescriptionDate: examinaton.ExaminationDate
        });
    }

    protected updateInterface(): void {
        super.updateInterface();

        if (!this.isNew() && !$('#recete-olustur-button').length) {
            $('<div class="text-center mt-4">' +
                '<button id="recete-olustur-button" class="btn btn-success" type="button">' +
                'Reçete Oluştur' +
                '</button>' +
              '</div>')
              .appendTo('.s-Form');

            $('#recete-olustur-button').on('click', () => this.openExaminationDialog());
        }
    }

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