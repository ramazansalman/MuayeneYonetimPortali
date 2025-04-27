import { IntegerEditor, ServiceLookupEditor, StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PrescriptionsForm {
    ExaminationId: IntegerEditor;
    DoctorId: ServiceLookupEditor;
    PatientId: ServiceLookupEditor;
    PrescriptionNote: StringEditor;
    PrescriptionDate: DateEditor;
}

export class PrescriptionsForm extends PrefixedContext {
    static readonly formKey = 'Prescriptions.Prescriptions';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PrescriptionsForm.init)  {
            PrescriptionsForm.init = true;

            var w0 = IntegerEditor;
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;

            initFormType(PrescriptionsForm, [
                'ExaminationId', w0,
                'DoctorId', w1,
                'PatientId', w1,
                'PrescriptionNote', w2,
                'PrescriptionDate', w3
            ]);
        }
    }
}