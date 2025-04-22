import { StringEditor, ServiceLookupEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface HospitalsForm {
    Name: StringEditor;
    CityId: ServiceLookupEditor;
    DistrictId: ServiceLookupEditor;
    DepartmentList: LookupEditor;
}

export class HospitalsForm extends PrefixedContext {
    static readonly formKey = 'Tanimlamalar.Hospitals';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!HospitalsForm.init)  {
            HospitalsForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = LookupEditor;

            initFormType(HospitalsForm, [
                'Name', w0,
                'CityId', w1,
                'DistrictId', w1,
                'DepartmentList', w2
            ]);
        }
    }
}