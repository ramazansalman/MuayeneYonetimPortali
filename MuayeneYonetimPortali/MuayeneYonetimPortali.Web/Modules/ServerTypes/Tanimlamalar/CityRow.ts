import { fieldsProxy } from "@serenity-is/corelib";

export interface CityRow {
    CityId?: number;
    Name?: string;
}

export abstract class CityRow {
    static readonly idProperty = 'CityId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Tanimlamalar.City';
    static readonly deletePermission = 'Tanimlamalar.City.General';
    static readonly insertPermission = 'Tanimlamalar.City.General';
    static readonly readPermission = 'Tanimlamalar.City.General';
    static readonly updatePermission = 'Tanimlamalar.City.General';

    static readonly Fields = fieldsProxy<CityRow>();
}