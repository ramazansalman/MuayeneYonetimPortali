import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DepartmentsForm {
    Name: StringEditor;
}

export class DepartmentsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Departments';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DepartmentsForm.init)  {
            DepartmentsForm.init = true;

            var w0 = StringEditor;

            initFormType(DepartmentsForm, [
                'Name', w0
            ]);
        }
    }
}