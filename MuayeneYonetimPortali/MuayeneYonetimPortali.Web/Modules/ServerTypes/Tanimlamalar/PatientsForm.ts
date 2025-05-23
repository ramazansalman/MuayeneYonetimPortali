﻿import { LookupEditor, StringEditor, EnumEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { NotesEditor } from "../../Note/Note/NotesEditor";
import { Gender } from "./Gender";
import { IsActive } from "./IsActive";

export interface PatientsForm {
    UserId: LookupEditor;
    Name: StringEditor;
    Surname: StringEditor;
    Gender: EnumEditor;
    BirthDate: DateEditor;
    Phone: StringEditor;
    Email: StringEditor;
    Tckn: StringEditor;
    NoteList: NotesEditor;
    IsActive: EnumEditor;
}

export class PatientsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Patients';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PatientsForm.init)  {
            PatientsForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = EnumEditor;
            var w3 = DateEditor;
            var w4 = NotesEditor;

            initFormType(PatientsForm, [
                'UserId', w0,
                'Name', w1,
                'Surname', w1,
                'Gender', w2,
                'BirthDate', w3,
                'Phone', w1,
                'Email', w1,
                'Tckn', w1,
                'NoteList', w4,
                'IsActive', w2
            ]);
        }
    }
}

[Gender, IsActive]; // referenced types