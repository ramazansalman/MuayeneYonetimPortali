﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface DistrictsRow {
    DistrictId?: number;
    Name?: string;
    CityId?: number;
    CityName?: string;
}

export abstract class DistrictsRow {
    static readonly idProperty = 'DistrictId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Tanimlamalar.Districts';
    static readonly lookupKey = 'Tanimlamalar.Districts';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<DistrictsRow>('Tanimlamalar.Districts') }
    static async getLookupAsync() { return getLookupAsync<DistrictsRow>('Tanimlamalar.Districts') }

    static readonly deletePermission = 'Tanimlamalar.Districts.General';
    static readonly insertPermission = 'Tanimlamalar.Districts.General';
    static readonly readPermission = 'Tanimlamalar.Districts.General';
    static readonly updatePermission = 'Tanimlamalar.Districts.General';

    static readonly Fields = fieldsProxy<DistrictsRow>();
}