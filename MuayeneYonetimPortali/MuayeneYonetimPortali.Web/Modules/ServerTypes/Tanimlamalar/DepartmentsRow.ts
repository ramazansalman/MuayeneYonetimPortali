import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface DepartmentsRow {
    DepartmentId?: number;
    Name?: string;
}

export abstract class DepartmentsRow {
    static readonly idProperty = 'DepartmentId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Tanimlamalar.Departments';
    static readonly lookupKey = 'Tanimlamalar.Departments';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<DepartmentsRow>('Tanimlamalar.Departments') }
    static async getLookupAsync() { return getLookupAsync<DepartmentsRow>('Tanimlamalar.Departments') }

    static readonly deletePermission = 'Tanimlamalar.Departments.General';
    static readonly insertPermission = 'Tanimlamalar.Departments.General';
    static readonly readPermission = 'Tanimlamalar.Departments.General';
    static readonly updatePermission = 'Tanimlamalar.Departments.General';

    static readonly Fields = fieldsProxy<DepartmentsRow>();
}