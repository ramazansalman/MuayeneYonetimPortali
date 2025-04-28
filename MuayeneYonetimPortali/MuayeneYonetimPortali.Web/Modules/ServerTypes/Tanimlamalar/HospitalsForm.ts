import { ServiceLookupEditor, LookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface HospitalsForm {
    CityId: ServiceLookupEditor;
    DistrictId: ServiceLookupEditor;
    DepartmentList: LookupEditor;
    Name: StringEditor;
}

export class HospitalsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Hospitals';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!HospitalsForm.init)  {
            HospitalsForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = StringEditor;

            initFormType(HospitalsForm, [
                'CityId', w0,
                'DistrictId', w0,
                'DepartmentList', w1,
                'Name', w2
            ]);
        }
    }
}