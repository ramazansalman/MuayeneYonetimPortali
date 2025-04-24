import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AppointmentsForm, AppointmentsRow, AppointmentsService } from '../../ServerTypes/Appointments';

@Decorators.registerClass('MuayeneYonetimPortali.Appointments.AppointmentsDialog')
export class AppointmentsDialog extends EntityDialog<AppointmentsRow, any> {
    protected getFormKey() { return AppointmentsForm.formKey; }
    protected getRowDefinition() { return AppointmentsRow; }
    protected getService() { return AppointmentsService.baseUrl; }

    protected form = new AppointmentsForm(this.idPrefix);
}