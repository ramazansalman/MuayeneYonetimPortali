import { fieldsProxy } from "@serenity-is/corelib";

export interface TwoFactorCodeRow {
    Id?: number;
    UserId?: number;
    Code?: string;
    ExpireTime?: string;
    Username?: string;
}

export abstract class TwoFactorCodeRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'Administration.TwoFactorCode';
    static readonly deletePermission = 'Administration:TwoFactorCode';
    static readonly insertPermission = 'Administration:TwoFactorCode';
    static readonly readPermission = 'Administration:TwoFactorCode';
    static readonly updatePermission = 'Administration:TwoFactorCode';

    static readonly Fields = fieldsProxy<TwoFactorCodeRow>();
}