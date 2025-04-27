import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ExaminationsRow } from "./ExaminationsRow";

export interface ExaminationsColumns {
    ExaminationId: Column<ExaminationsRow>;
    AppointmentId: Column<ExaminationsRow>;
    DoctorName: Column<ExaminationsRow>;
    PatientName: Column<ExaminationsRow>;
    Complaint: Column<ExaminationsRow>;
    ExaminationDate: Column<ExaminationsRow>;
    DoctorNote: Column<ExaminationsRow>;
}

export class ExaminationsColumns extends ColumnsBase<ExaminationsRow> {
    static readonly columnsKey = 'Examinations.Examinations';
    static readonly Fields = fieldsProxy<ExaminationsColumns>();
}