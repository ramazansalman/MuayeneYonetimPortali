import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AppointmentsForm, AppointmentsRow, AppointmentsService } from '../../ServerTypes/Appointments';
import { ExaminationsDialog } from '../../Examinations/Examinations/ExaminationsDialog';

declare var $: any;

@Decorators.registerClass('MuayeneYonetimPortali.Appointments.AppointmentsDialog')
export class AppointmentsDialog extends EntityDialog<AppointmentsRow, any> {
    protected getFormKey() { return AppointmentsForm.formKey; }
    protected getRowDefinition() { return AppointmentsRow; }
    protected getService() { return AppointmentsService.baseUrl; }
    protected form = new AppointmentsForm(this.idPrefix);

    private openExaminationDialog() {
        if (!this.isEditMode())
            return;

        const appointment = this.entity!;
        const examinationDialog = new ExaminationsDialog();
        examinationDialog.loadEntityAndOpenDialog({
            AppointmentId: appointment.AppointmentId,
            DoctorId: appointment.DoctorId,
            PatientId: appointment.PatientId,
            ExaminationDate: appointment.AppointmentDate
        });
    }

    protected updateInterface(): void {
        super.updateInterface();

        setTimeout(() => {
            $('.s-DateTimeEditor.time').hide();
            $('.inplace-now').hide();
        }, 200);

        if (!$('#hours-result').length) {
            $('<div id="hours-result" class="mt-2"></div>')
                .appendTo($('.category:has(input[name="AppointmentDate"])'));
        }

        this.form.AppointmentDate.changeSelect2(e => {
            $('#selected-hour').remove();
            this.form.AppointmentDate.value = this.form.AppointmentDate.value?.split('T')[0];
            this.loadAvailableHours();
        });

        if (!this.isNew() && this.form.AppointmentDate.value) {
            this.loadAvailableHours();
        }

        if (!this.isNew() && !$('#muayene-olustur-button').length) {
            $('<div class="text-center mt-4">' +
                '<button id="muayene-olustur-button" class="btn btn-success" type="button">' +
                'Muayene Oluştur' +
                '</button>' +
              '</div>')
              .appendTo('.s-Form');

            $('#muayene-olustur-button').on('click', () => this.openExaminationDialog());
        }
    }

    private loadAvailableHours() {
        const doctorId = this.form.DoctorId.value;
        const date = this.form.AppointmentDate.value;
        const allTimes = this.generateAllTimes();
        const saatDiv = $('#hours-result').empty();

        if (!doctorId || !date) {
            allTimes.forEach(time => {
                saatDiv.append($('<button class="btn btn-outline-secondary m-1" disabled></button>').text(time));
            });
            $('#selected-hour').remove();
            $('<div id="selected-hour" class="mt-2 text-info"><strong>Seçilen randevu saati:</strong> Lütfen saat seçiniz</div>').appendTo(saatDiv);
            return;
        }

        AppointmentsService.GetAvailableHours({
            DoctorId: parseInt(doctorId, 10),
            Date: date
        }, res => {
            const taken = allTimes.filter(x => !res.Entities.includes(x));
            const currentValue = new Date(this.form.AppointmentDate.value);
            const currentHourMin = currentValue.toTimeString().substring(0, 5);

            allTimes.forEach(saat => {
                const saatBtn = $('<button class="btn m-1"></button>').text(saat);
                const isTaken = taken.includes(saat);
                const isSelected = saat === currentHourMin;

                if (isTaken && !isSelected) {
                    saatBtn.addClass('btn-outline-secondary').attr('disabled', true);
                } else {
                    saatBtn.addClass(isSelected ? 'btn-success' : 'btn-outline-primary');

                    saatBtn.on('click', () => {
                        $('#hours-result button').removeClass('btn-success').addClass('btn-outline-primary');
                        saatBtn.removeClass('btn-outline-primary').addClass('btn-success');

                        const [hour, minute] = saat.split(':').map(Number);
                        const selectedDate = new Date(date);
                        selectedDate.setHours(hour, minute, 0, 0);

                        this.form.AppointmentDate.value = selectedDate.toISOString();
                        this.form.AppointmentDate.valueAsDate = selectedDate;

                        $('#selected-hour').remove();
                        $('<div id="selected-hour" class="mt-2 text-info"><strong>Seçilen randevu saati:</strong> ' + saat + '</div>').appendTo(saatDiv);
                    });
                }

                saatDiv.append(saatBtn);
            });

            $('#selected-hour').remove();
            $('<div id="selected-hour" class="mt-2 text-info"><strong>Seçilen randevu saati:</strong> ' +
                (allTimes.includes(currentHourMin) ? currentHourMin : 'Lütfen saat seçiniz') + '</div>').appendTo(saatDiv);
        });
    }

    private generateAllTimes(): string[] {
        const times: string[] = [];
        let current = new Date(0, 0, 0, 8, 0, 0);
        const end = new Date(0, 0, 0, 15, 40, 0);

        while (current <= end) {
            times.push(current.toTimeString().substring(0, 5));
            current.setMinutes(current.getMinutes() + 20);
        }

        return times;
    }
}
