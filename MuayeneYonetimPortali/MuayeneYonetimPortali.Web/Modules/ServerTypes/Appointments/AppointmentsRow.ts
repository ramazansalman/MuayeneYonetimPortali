import { fieldsProxy } from "@serenity-is/corelib";

export interface AppointmentsRow {
    AppointmentId?: number;
    CityId?: number;
    DistrictId?: number;
    HospitalId?: number;
    DepartmentId?: number;
    DoctorId?: number;
    PatientId?: number;
    AppointmentDate?: string;
    CityName?: string;
    DistrictName?: string;
    HospitalName?: string;
    DepartmentName?: string;
    DoctorName?: string;
    PatientName?: string;
}

export abstract class AppointmentsRow {
    static readonly idProperty = 'AppointmentId';
    static readonly localTextPrefix = 'Appointments.Appointments';
    static readonly deletePermission = 'Appointments.General';
    static readonly insertPermission = 'Appointments.General';
    static readonly readPermission = 'Appointments.General';
    static readonly updatePermission = 'Appointments.General';

    static readonly Fields = fieldsProxy<AppointmentsRow>();
}