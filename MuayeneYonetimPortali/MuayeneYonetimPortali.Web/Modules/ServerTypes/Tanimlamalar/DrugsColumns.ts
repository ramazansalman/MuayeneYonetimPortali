import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DrugsRow } from "./DrugsRow";

export interface DrugsColumns {
    DrugId: Column<DrugsRow>;
    Name: Column<DrugsRow>;
    IsActive: Column<DrugsRow>;
    Barcode: Column<DrugsRow>;
    CompanyName: Column<DrugsRow>;
    AtcCode: Column<DrugsRow>;
    AtcName: Column<DrugsRow>;
}

export class DrugsColumns extends ColumnsBase<DrugsRow> {
    static readonly columnsKey = 'Tanimlamalar.Drugs';
    static readonly Fields = fieldsProxy<DrugsColumns>();
}