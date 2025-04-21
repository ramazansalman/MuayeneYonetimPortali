import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DistrictsRow } from "./DistrictsRow";

export interface DistrictsColumns {
    DistrictId: Column<DistrictsRow>;
    Name: Column<DistrictsRow>;
    CityName: Column<DistrictsRow>;
}

export class DistrictsColumns extends ColumnsBase<DistrictsRow> {
    static readonly columnsKey = 'Tanimlamalar.Districts';
    static readonly Fields = fieldsProxy<DistrictsColumns>();
}