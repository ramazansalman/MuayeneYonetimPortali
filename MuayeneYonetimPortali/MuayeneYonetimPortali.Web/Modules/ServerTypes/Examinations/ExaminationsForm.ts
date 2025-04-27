import { ServiceLookupEditor, StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ExaminationsForm {
    AppointmentId: ServiceLookupEditor;
    DoctorId: ServiceLookupEditor;
    PatientId: ServiceLookupEditor;
    Complaint: StringEditor;
    ExaminationDate: DateEditor;
    DoctorNote: StringEditor;
}

export class ExaminationsForm extends PrefixedContext {
    static readonly formKey = 'Examinations.Examinations';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExaminationsForm.init)  {
            ExaminationsForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;

            initFormType(ExaminationsForm, [
                'AppointmentId', w0,
                'DoctorId', w0,
                'PatientId', w0,
                'Complaint', w1,
                'ExaminationDate', w2,
                'DoctorNote', w1
            ]);
        }
    }
}