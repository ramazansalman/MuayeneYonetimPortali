import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DrugListFormatter } from "../../Prescriptions/Prescriptions/DrugListFormatter";
import { PrescriptionsRow } from "./PrescriptionsRow";

export interface PrescriptionsColumns {
    PrescriptionId: Column<PrescriptionsRow>;
    ExaminationComplaint: Column<PrescriptionsRow>;
    DoctorName: Column<PrescriptionsRow>;
    PatientName: Column<PrescriptionsRow>;
    PrescriptionNote: Column<PrescriptionsRow>;
    PrescriptionDate: Column<PrescriptionsRow>;
    DrugList: Column<PrescriptionsRow>;
}

export class PrescriptionsColumns extends ColumnsBase<PrescriptionsRow> {
    static readonly columnsKey = 'Prescriptions.Prescriptions';
    static readonly Fields = fieldsProxy<PrescriptionsColumns>();
}

[DrugListFormatter]; // referenced types