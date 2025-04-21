import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { HospitalsRow } from "./HospitalsRow";

export interface HospitalsColumns {
    HospitalId: Column<HospitalsRow>;
    Name: Column<HospitalsRow>;
    DistrictName: Column<HospitalsRow>;
    CityName: Column<HospitalsRow>;
}

export class HospitalsColumns extends ColumnsBase<HospitalsRow> {
    static readonly columnsKey = 'Tanimlamalar.Hospitals';
    static readonly Fields = fieldsProxy<HospitalsColumns>();
}