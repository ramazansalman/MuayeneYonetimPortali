import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface PrescriptionsRow {
    PrescriptionId?: number;
    ExaminationId?: number;
    DoctorId?: number;
    PatientId?: number;
    PrescriptionNote?: string;
    PrescriptionDate?: string;
    ExaminationComplaint?: string;
    DoctorName?: string;
    PatientName?: string;
    DrugList?: number[];
}

export abstract class PrescriptionsRow {
    static readonly idProperty = 'PrescriptionId';
    static readonly nameProperty = 'PrescriptionNote';
    static readonly localTextPrefix = 'Prescriptions.Prescriptions';
    static readonly lookupKey = 'Prescriptions.Prescriptions';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PrescriptionsRow>('Prescriptions.Prescriptions') }
    static async getLookupAsync() { return getLookupAsync<PrescriptionsRow>('Prescriptions.Prescriptions') }

    static readonly deletePermission = 'Prescriptions.Prescriptions.General';
    static readonly insertPermission = 'Prescriptions.Prescriptions.General';
    static readonly readPermission = 'Prescriptions.Prescriptions.General';
    static readonly updatePermission = 'Prescriptions.Prescriptions.General';

    static readonly Fields = fieldsProxy<PrescriptionsRow>();
}