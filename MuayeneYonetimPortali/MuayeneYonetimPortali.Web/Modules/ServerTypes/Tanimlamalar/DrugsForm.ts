import { StringEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DrugsForm {
    Name: StringEditor;
    IsActive: BooleanEditor;
    Barcode: StringEditor;
    CompanyName: StringEditor;
    AtcCode: StringEditor;
    AtcName: StringEditor;
}

export class DrugsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Drugs';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DrugsForm.init)  {
            DrugsForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(DrugsForm, [
                'Name', w0,
                'IsActive', w1,
                'Barcode', w0,
                'CompanyName', w0,
                'AtcCode', w0,
                'AtcName', w0
            ]);
        }
    }
}