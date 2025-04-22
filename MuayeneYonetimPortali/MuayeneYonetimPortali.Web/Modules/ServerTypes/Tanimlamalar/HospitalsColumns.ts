import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DepartmentsListFormatter } from "../../Tanimlamalar/Hospitals/DepartmentsListFormatter";
import { HospitalsRow } from "./HospitalsRow";

export interface HospitalsColumns {
    HospitalId: Column<HospitalsRow>;
    Name: Column<HospitalsRow>;
    CityName: Column<HospitalsRow>;
    DistrictName: Column<HospitalsRow>;
    DepartmentList: Column<HospitalsRow>;
}

export class HospitalsColumns extends ColumnsBase<HospitalsRow> {
    static readonly columnsKey = 'Tanimlamalar.Hospitals';
    static readonly Fields = fieldsProxy<HospitalsColumns>();
}

[DepartmentsListFormatter]; // referenced types