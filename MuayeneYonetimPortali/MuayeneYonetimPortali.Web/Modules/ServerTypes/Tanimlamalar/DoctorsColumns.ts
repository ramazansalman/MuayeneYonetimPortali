import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DoctorsRow } from "./DoctorsRow";
import { Gender } from "./Gender";

export interface DoctorsColumns {
    DoctorId: Column<DoctorsRow>;
    Username: Column<DoctorsRow>;
    Name: Column<DoctorsRow>;
    Surname: Column<DoctorsRow>;
    Gender: Column<DoctorsRow>;
    BirthDate: Column<DoctorsRow>;
    HospitalName: Column<DoctorsRow>;
    DepartmentName: Column<DoctorsRow>;
}

export class DoctorsColumns extends ColumnsBase<DoctorsRow> {
    static readonly columnsKey = 'Tanimlamalar.Doctors';
    static readonly Fields = fieldsProxy<DoctorsColumns>();
}

[Gender]; // referenced types