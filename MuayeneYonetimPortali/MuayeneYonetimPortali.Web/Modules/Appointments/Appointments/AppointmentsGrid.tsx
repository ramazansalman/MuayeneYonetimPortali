import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AppointmentsColumns, AppointmentsRow, AppointmentsService } from '../../ServerTypes/Appointments';
import { AppointmentsDialog } from './AppointmentsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Appointments.AppointmentsGrid')
export class AppointmentsGrid extends EntityGrid<AppointmentsRow> {
    protected getColumnsKey() { return AppointmentsColumns.columnsKey; }
    protected getDialogType() { return AppointmentsDialog; }
    protected getRowDefinition() { return AppointmentsRow; }
    protected getService() { return AppointmentsService.baseUrl; }
}