import { fieldsProxy } from "@serenity-is/corelib";
import { NoteRow } from "../Note/NoteRow";
import { Gender } from "./Gender";

export interface PatientsRow {
    PatientId?: number;
    UserId?: number;
    Name?: string;
    Surname?: string;
    Gender?: Gender;
    BirthDate?: string;
    Phone?: string;
    Email?: string;
    Tckn?: string;
    Username?: string;
    NoteList?: NoteRow[];
}

export abstract class PatientsRow {
    static readonly idProperty = 'PatientId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Tanimlamalar.Patients';
    static readonly deletePermission = 'Tanimlamalar.Patients.General';
    static readonly insertPermission = 'Tanimlamalar.Patients.General';
    static readonly readPermission = 'Tanimlamalar.Patients.General';
    static readonly updatePermission = 'Tanimlamalar.Patients.General';

    static readonly Fields = fieldsProxy<PatientsRow>();
}