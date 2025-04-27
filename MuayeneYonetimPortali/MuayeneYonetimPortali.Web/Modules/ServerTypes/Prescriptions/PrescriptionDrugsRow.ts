import { fieldsProxy } from "@serenity-is/corelib";

export interface PrescriptionDrugsRow {
    PrescriptionDrugId?: number;
    PrescriptionId?: number;
    DrugId?: number;
    Usage?: string;
    PrescriptionNote?: string;
    DrugName?: string;
}

export abstract class PrescriptionDrugsRow {
    static readonly idProperty = 'PrescriptionDrugId';
    static readonly nameProperty = 'Usage';
    static readonly localTextPrefix = 'Prescriptions.PrescriptionDrugs';
    static readonly deletePermission = 'Prescriptions.PrescriptionDrugs.General';
    static readonly insertPermission = 'Prescriptions.PrescriptionDrugs.General';
    static readonly readPermission = 'Prescriptions.PrescriptionDrugs.General';
    static readonly updatePermission = 'Prescriptions.PrescriptionDrugs.General';

    static readonly Fields = fieldsProxy<PrescriptionDrugsRow>();
}