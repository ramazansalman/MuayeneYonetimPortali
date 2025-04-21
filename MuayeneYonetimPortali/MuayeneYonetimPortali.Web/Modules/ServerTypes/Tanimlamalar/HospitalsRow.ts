import { fieldsProxy } from "@serenity-is/corelib";

export interface HospitalsRow {
    HospitalId?: number;
    Name?: string;
    DistrictId?: number;
    DistrictName?: string;
}

export abstract class HospitalsRow {
    static readonly idProperty = 'HospitalId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Tanimlamalar.Hospitals';
    static readonly deletePermission = 'Tanimlamalar.Hospitals.General';
    static readonly insertPermission = 'Tanimlamalar.Hospitals.General';
    static readonly readPermission = 'Tanimlamalar.Hospitals.General';
    static readonly updatePermission = 'Tanimlamalar.Hospitals.General';

    static readonly Fields = fieldsProxy<HospitalsRow>();
}