import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Gender } from "./Gender";
import { PatientsRow } from "./PatientsRow";

export interface PatientsColumns {
    PatientId: Column<PatientsRow>;
    Username: Column<PatientsRow>;
    Name: Column<PatientsRow>;
    Surname: Column<PatientsRow>;
    Gender: Column<PatientsRow>;
    BirthDate: Column<PatientsRow>;
}

export class PatientsColumns extends ColumnsBase<PatientsRow> {
    static readonly columnsKey = 'Tanimlamalar.Patients';
    static readonly Fields = fieldsProxy<PatientsColumns>();
}

[Gender]; // referenced types