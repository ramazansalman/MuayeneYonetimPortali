import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CityRow } from "./CityRow";

export interface CityColumns {
    CityId: Column<CityRow>;
    Name: Column<CityRow>;
}

export class CityColumns extends ColumnsBase<CityRow> {
    static readonly columnsKey = 'Tanimlamalar.City';
    static readonly Fields = fieldsProxy<CityColumns>();
}