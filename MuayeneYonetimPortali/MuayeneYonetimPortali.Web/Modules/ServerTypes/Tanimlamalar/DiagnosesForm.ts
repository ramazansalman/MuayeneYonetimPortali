import { StringEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DiagnosesForm {
    Code: StringEditor;
    Name: StringEditor;
    IsActive: BooleanEditor;
}

export class DiagnosesForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Diagnoses';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DiagnosesForm.init)  {
            DiagnosesForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(DiagnosesForm, [
                'Code', w0,
                'Name', w0,
                'IsActive', w1
            ]);
        }
    }
}