import { LookupEditor, StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TwoFactorCodeForm {
    UserId: LookupEditor;
    Code: StringEditor;
    ExpireTime: DateEditor;
}

export class TwoFactorCodeForm extends PrefixedContext {
    static readonly formKey = 'Administration.TwoFactorCode';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TwoFactorCodeForm.init)  {
            TwoFactorCodeForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;

            initFormType(TwoFactorCodeForm, [
                'UserId', w0,
                'Code', w1,
                'ExpireTime', w2
            ]);
        }
    }
}