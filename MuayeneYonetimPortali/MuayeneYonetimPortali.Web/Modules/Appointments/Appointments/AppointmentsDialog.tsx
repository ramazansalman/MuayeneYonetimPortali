import { Decorators, EntityDialog} from '@serenity-is/corelib';
import { AppointmentsForm, AppointmentsRow, AppointmentsService } from '../../ServerTypes/Appointments';
declare var $: any;

@Decorators.registerClass('MuayeneYonetimPortali.Appointments.AppointmentsDialog')
export class AppointmentsDialog extends EntityDialog<AppointmentsRow, any> {
    protected getFormKey() { return AppointmentsForm.formKey; }
    protected getRowDefinition() { return AppointmentsRow; }
    protected getService() { return AppointmentsService.baseUrl; }
    protected form = new AppointmentsForm(this.idPrefix);

    protected updateInterface(): void {
        super.updateInterface();
        setTimeout(() => {
            $('.s-DateTimeEditor.time').hide();  // saat dropdownunu gizle
            $('.inplace-now').hide();
        }, 200);
        

        if (!$('#hours-result').length) {
            $('<div id="hours-result" class="mt-2"></div>')
                .insertAfter(this.form.AppointmentDate.element);
        }

        this.form.AppointmentDate.changeSelect2(e => {
            this.loadAvailableHours();
        });

        if (!this.isNew() && this.form.AppointmentDate.value) {
            this.loadAvailableHours();
        }
    }

    private loadAvailableHours() {
        const doctorId = this.form.DoctorId.value;
        const date = this.form.AppointmentDate.value;

        if (!doctorId || !date)
            return;

        AppointmentsService.GetAvailableHours({
            DoctorId: parseInt(doctorId, 10),
            Date: date
        }, res => {
            const saatDiv = $('#hours-result').empty();

            res.Entities.forEach(saat => {
                const saatBtn = $('<button class="btn btn-outline-primary m-1"></button>')
                    .text(saat)
                    .on('click', () => {
                        $('#hours-result button').removeClass('btn-success').addClass('btn-outline-primary');
                        saatBtn.removeClass('btn-outline-primary').addClass('btn-success');
                    
                        const [hour, minute] = saat.split(':').map(Number);
                        const selectedDate = new Date(this.form.AppointmentDate.value);
                        
                        selectedDate.setHours(hour);
                        selectedDate.setMinutes(minute);
                        selectedDate.setSeconds(0);
                        selectedDate.setMilliseconds(0);
                        
                        this.form.AppointmentDate.value = selectedDate.toISOString();
                        this.form.AppointmentDate.valueAsDate = selectedDate;
                        
                        console.log(selectedDate.toISOString());
                        
                        $('#selected-hour').remove();
                        $('<div id="selected-hour" class="mt-2 text-info"><strong>\uD83D\uDD52 Seçilen randevu saati:</strong> ' + selectedDate.toLocaleString('tr-TR') + '</div>')
                            .insertAfter(saatDiv);
                    });
                    

                saatDiv.append(saatBtn);
            });
        });
    }
}
