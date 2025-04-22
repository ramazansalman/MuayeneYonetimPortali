import { LookupEditor, StringEditor, EnumEditor, DateEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { Gender } from "./Gender";

export interface DoctorsForm {
    UserId: LookupEditor;
    Name: StringEditor;
    Surname: StringEditor;
    Gender: EnumEditor;
    BirthDate: DateEditor;
    HospitalId: ServiceLookupEditor;
    DepartmentId: LookupEditor;
}

export class DoctorsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Doctors';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DoctorsForm.init)  {
            DoctorsForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = EnumEditor;
            var w3 = DateEditor;
            var w4 = ServiceLookupEditor;

            initFormType(DoctorsForm, [
                'UserId', w0,
                'Name', w1,
                'Surname', w1,
                'Gender', w2,
                'BirthDate', w3,
                'HospitalId', w4,
                'DepartmentId', w0
            ]);
        }
    }
}

[Gender]; // referenced types