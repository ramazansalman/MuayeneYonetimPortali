import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AppointmentsRow } from "./AppointmentsRow";

export interface AppointmentsColumns {
    AppointmentId: Column<AppointmentsRow>;
    AppointmentDate: Column<AppointmentsRow>;
    CityName: Column<AppointmentsRow>;
    DistrictName: Column<AppointmentsRow>;
    HospitalName: Column<AppointmentsRow>;
    DepartmentName: Column<AppointmentsRow>;
    DoctorFullName: Column<AppointmentsRow>;
    PatientFullName: Column<AppointmentsRow>;
}

export class AppointmentsColumns extends ColumnsBase<AppointmentsRow> {
    static readonly columnsKey = 'Appointments.Appointments';
    static readonly Fields = fieldsProxy<AppointmentsColumns>();
}