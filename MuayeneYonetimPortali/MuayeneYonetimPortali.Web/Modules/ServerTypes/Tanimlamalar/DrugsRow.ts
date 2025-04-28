import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface DrugsRow {
    DrugId?: number;
    Name?: string;
    IsActive?: boolean;
    Barcode?: string;
    CompanyName?: string;
    AtcCode?: string;
    AtcName?: string;
}

export abstract class DrugsRow {
    static readonly idProperty = 'DrugId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Tanimlamalar.Drugs';
    static readonly lookupKey = 'Tanimlamalar.Drugs';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<DrugsRow>('Tanimlamalar.Drugs') }
    static async getLookupAsync() { return getLookupAsync<DrugsRow>('Tanimlamalar.Drugs') }

    static readonly deletePermission = 'Tanimlamalar.Drugs.General';
    static readonly insertPermission = 'Tanimlamalar.Drugs.General';
    static readonly readPermission = 'Tanimlamalar.Drugs.General';
    static readonly updatePermission = 'Tanimlamalar.Drugs.General';

    static readonly Fields = fieldsProxy<DrugsRow>();
}