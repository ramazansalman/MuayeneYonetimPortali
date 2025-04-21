import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DepartmentsRow } from "./DepartmentsRow";

export interface DepartmentsColumns {
    DepartmentId: Column<DepartmentsRow>;
    Name: Column<DepartmentsRow>;
}

export class DepartmentsColumns extends ColumnsBase<DepartmentsRow> {
    static readonly columnsKey = 'Tanimlamalar.Departments';
    static readonly Fields = fieldsProxy<DepartmentsColumns>();
}