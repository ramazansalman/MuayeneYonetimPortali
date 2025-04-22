import { LookupEditor, StringEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PatientsForm {
    UserId: LookupEditor;
    Name: StringEditor;
    Surname: StringEditor;
    Gender: IntegerEditor;
    BirthDate: DateEditor;
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
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(PatientsForm, [
                'UserId', w0,
                'Name', w1,
                'Surname', w1,
                'Gender', w2,
                'BirthDate', w3
            ]);
        }
    }
}