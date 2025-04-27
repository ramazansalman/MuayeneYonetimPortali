import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DiagnosesRow } from "./DiagnosesRow";

export interface DiagnosesColumns {
    DiagnosisId: Column<DiagnosesRow>;
    Code: Column<DiagnosesRow>;
    Name: Column<DiagnosesRow>;
    IsActive: Column<DiagnosesRow>;
}

export class DiagnosesColumns extends ColumnsBase<DiagnosesRow> {
    static readonly columnsKey = 'Tanimlamalar.Diagnoses';
    static readonly Fields = fieldsProxy<DiagnosesColumns>();
}