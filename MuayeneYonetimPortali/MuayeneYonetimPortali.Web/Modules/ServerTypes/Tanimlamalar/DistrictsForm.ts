import { StringEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DistrictsForm {
    Name: StringEditor;
    CityId: ServiceLookupEditor;
}

export class DistrictsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Districts';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DistrictsForm.init)  {
            DistrictsForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;

            initFormType(DistrictsForm, [
                'Name', w0,
                'CityId', w1
            ]);
        }
    }
}