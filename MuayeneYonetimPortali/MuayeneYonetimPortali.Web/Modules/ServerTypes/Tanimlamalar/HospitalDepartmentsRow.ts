import { fieldsProxy } from "@serenity-is/corelib";

export interface HospitalDepartmentsRow {
    HospitalDepartmentId?: number;
    HospitalId?: number;
    DepartmentId?: number;
    HospitalName?: string;
    DepartmentName?: string;
}

export abstract class HospitalDepartmentsRow {
    static readonly idProperty = 'HospitalDepartmentId';
    static readonly localTextPrefix = 'Tanimlamalar.HospitalDepartments';
    static readonly deletePermission = 'Tanimlamalar.HospitalDepartments.General';
    static readonly insertPermission = 'Tanimlamalar.HospitalDepartments.General';
    static readonly readPermission = 'Tanimlamalar.HospitalDepartments.General';
    static readonly updatePermission = 'Tanimlamalar.HospitalDepartments.General';

    static readonly Fields = fieldsProxy<HospitalDepartmentsRow>();
}