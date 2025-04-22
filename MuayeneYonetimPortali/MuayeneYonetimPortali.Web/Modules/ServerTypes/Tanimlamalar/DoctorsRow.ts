import { fieldsProxy } from "@serenity-is/corelib";
import { Gender } from "./Gender";

export interface DoctorsRow {
    DoctorId?: number;
    UserId?: number;
    Name?: string;
    Surname?: string;
    Gender?: Gender;
    BirthDate?: string;
    HospitalId?: number;
    DepartmentId?: number;
    Username?: string;
    HospitalName?: string;
    DepartmentName?: string;
}

export abstract class DoctorsRow {
    static readonly idProperty = 'DoctorId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Tanimlamalar.Doctors';
    static readonly deletePermission = 'Tanimlamalar.Doctors.General';
    static readonly insertPermission = 'Tanimlamalar.Doctors.General';
    static readonly readPermission = 'Tanimlamalar.Doctors.General';
    static readonly updatePermission = 'Tanimlamalar.Doctors.General';

    static readonly Fields = fieldsProxy<DoctorsRow>();
}