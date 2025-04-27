import { fieldsProxy } from "@serenity-is/corelib";

export interface ExaminationsRow {
    ExaminationId?: number;
    AppointmentId?: number;
    DoctorId?: number;
    PatientId?: number;
    Complaint?: string;
    ExaminationDate?: string;
    DoctorNote?: string;
    DoctorName?: string;
    PatientName?: string;
}

export abstract class ExaminationsRow {
    static readonly idProperty = 'ExaminationId';
    static readonly nameProperty = 'Complaint';
    static readonly localTextPrefix = 'Examinations.Examinations';
    static readonly deletePermission = 'Examinations.Examinations.General';
    static readonly insertPermission = 'Examinations.Examinations.General';
    static readonly readPermission = 'Examinations.Examinations.General';
    static readonly updatePermission = 'Examinations.Examinations.General';

    static readonly Fields = fieldsProxy<ExaminationsRow>();
}