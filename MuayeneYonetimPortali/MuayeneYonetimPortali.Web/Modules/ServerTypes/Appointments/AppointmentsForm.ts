import { ServiceLookupEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AppointmentsForm {
    CityId: ServiceLookupEditor;
    DistrictId: LookupEditor;
    HospitalId: ServiceLookupEditor;
    DepartmentId: LookupEditor;
    DoctorId: ServiceLookupEditor;
    PatientId: ServiceLookupEditor;
    AppointmentDate: DateEditor;
}

export class AppointmentsForm extends PrefixedContext {
    static readonly formKey = 'Appointments.Appointments';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AppointmentsForm.init)  {
            AppointmentsForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(AppointmentsForm, [
                'CityId', w0,
                'DistrictId', w1,
                'HospitalId', w0,
                'DepartmentId', w1,
                'DoctorId', w0,
                'PatientId', w0,
                'AppointmentDate', w2
            ]);
        }
    }
}