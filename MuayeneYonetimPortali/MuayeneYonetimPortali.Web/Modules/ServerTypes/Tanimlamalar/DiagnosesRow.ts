import { fieldsProxy } from "@serenity-is/corelib";

export interface DiagnosesRow {
    DiagnosisId?: number;
    Code?: string;
    Name?: string;
    IsActive?: boolean;
}

export abstract class DiagnosesRow {
    static readonly idProperty = 'DiagnosisId';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'Tanimlamalar.Diagnoses';
    static readonly deletePermission = 'Tanimlamalar.Diagnoses.General';
    static readonly insertPermission = 'Tanimlamalar.Diagnoses.General';
    static readonly readPermission = 'Tanimlamalar.Diagnoses.General';
    static readonly updatePermission = 'Tanimlamalar.Diagnoses.General';

    static readonly Fields = fieldsProxy<DiagnosesRow>();
}