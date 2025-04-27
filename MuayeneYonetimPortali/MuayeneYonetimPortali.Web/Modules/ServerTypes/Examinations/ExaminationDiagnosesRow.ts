import { fieldsProxy } from "@serenity-is/corelib";

export interface ExaminationDiagnosesRow {
    ExaminationId?: number;
    DiagnosisId?: number;
    ExaminationComplaint?: string;
    DiagnosisCode?: string;
}

export abstract class ExaminationDiagnosesRow {
    static readonly idProperty = 'ExaminationId';
    static readonly localTextPrefix = 'Examinations.ExaminationDiagnoses';
    static readonly deletePermission = 'Examination.ExaminationDiagnoses.General';
    static readonly insertPermission = 'Examination.ExaminationDiagnoses.General';
    static readonly readPermission = 'Examination.ExaminationDiagnoses.General';
    static readonly updatePermission = 'Examination.ExaminationDiagnoses.General';

    static readonly Fields = fieldsProxy<ExaminationDiagnosesRow>();
}