import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CityForm {
    Name: StringEditor;
}

export class CityForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.City';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CityForm.init)  {
            CityForm.init = true;

            var w0 = StringEditor;

            initFormType(CityForm, [
                'Name', w0
            ]);
        }
    }
}