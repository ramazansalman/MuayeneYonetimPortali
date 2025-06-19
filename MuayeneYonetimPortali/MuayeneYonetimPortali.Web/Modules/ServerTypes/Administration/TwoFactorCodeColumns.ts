import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TwoFactorCodeRow } from "./TwoFactorCodeRow";

export interface TwoFactorCodeColumns {
    Id: Column<TwoFactorCodeRow>;
    Username: Column<TwoFactorCodeRow>;
    Code: Column<TwoFactorCodeRow>;
    ExpireTime: Column<TwoFactorCodeRow>;
}

export class TwoFactorCodeColumns extends ColumnsBase<TwoFactorCodeRow> {
    static readonly columnsKey = 'Administration.TwoFactorCode';
    static readonly Fields = fieldsProxy<TwoFactorCodeColumns>();
}