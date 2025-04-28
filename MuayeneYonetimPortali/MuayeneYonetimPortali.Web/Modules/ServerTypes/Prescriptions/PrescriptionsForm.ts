import { IntegerEditor, ServiceLookupEditor, StringEditor, DateEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PrescriptionsForm {
    ExaminationId: IntegerEditor;
    DoctorId: ServiceLookupEditor;
    PatientId: ServiceLookupEditor;
    PrescriptionNote: StringEditor;
    PrescriptionDate: DateEditor;
    DrugList: LookupEditor;
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
            var w4 = LookupEditor;

            initFormType(PrescriptionsForm, [
                'ExaminationId', w0,
                'DoctorId', w1,
                'PatientId', w1,
                'PrescriptionNote', w2,
                'PrescriptionDate', w3,
                'DrugList', w4
            ]);
        }
    }
}