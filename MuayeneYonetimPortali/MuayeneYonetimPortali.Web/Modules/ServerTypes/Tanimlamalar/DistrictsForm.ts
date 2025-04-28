import { ServiceLookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DistrictsForm {
    CityId: ServiceLookupEditor;
    Name: StringEditor;
}

export class DistrictsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Districts';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DistrictsForm.init)  {
            DistrictsForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;

            initFormType(DistrictsForm, [
                'CityId', w0,
                'Name', w1
            ]);
        }
    }
}