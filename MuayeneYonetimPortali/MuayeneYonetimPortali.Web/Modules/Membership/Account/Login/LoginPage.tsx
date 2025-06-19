import { ErrorHandling, PropertyPanel, WidgetProps, notifyError, parseQueryString, resolveUrl, serviceCall } from "@serenity-is/corelib";
import { LoginForm, LoginRequest } from "../../../ServerTypes/Membership";
import { LoginFormTexts } from "../../../ServerTypes/Texts";
import { AccountPanelTitle } from "../AccountPanelTitle";

export default function pageInit(opt?: { activated: string }) {
    var loginPanel = new LoginPanel({ element: '#LoginPanel' });

    if (opt?.activated) {
        loginPanel.form.Username.value = opt.activated;
        loginPanel.form.Password.element.getNode().focus();
    }
}

class LoginPanel extends PropertyPanel<LoginRequest, any> {

    public readonly form = new LoginForm(this.idPrefix);

    protected getFormKey() { return LoginForm.formKey; }

    constructor(props?: WidgetProps<any>) {
        super(props);
    }

    protected loginClick() {
        if (!this.validateForm())
            return;

        var request = this.getSaveEntity();

        serviceCall({
            url: resolveUrl('~/Account/Login'),
            request: request,
            onSuccess: () => {
                const q = parseQueryString();
                const returnUrl = q['returnUrl'];
                if (returnUrl && /^\/(?!\/|\\)/.test(returnUrl)) {
                    window.location.href = returnUrl;
                } else {
                    window.location.href = resolveUrl("~/");
                }
            },
            onError: response => {
                // Handle 2FA redirect FIRST!
                if (response?.Error?.Code === "RedirectUserTo" && response.Error.Message) {
                    window.location.href = response.Error.Message;
                    return;
                }
                // Only show error if not a redirect
                if (response?.Error?.Message?.length) {
                    notifyError(response.Error.Message);
                    this.form.Password.element.getNode().focus();
                    return;
                }
                ErrorHandling.showServiceError(response.Error);
            }
        });

    }

    protected getReturnUrl() {
        var q = parseQueryString();
        return q['returnUrl'] || q['ReturnUrl'];
    }

    protected redirectToReturnUrl() {
        var returnUrl = this.getReturnUrl();

        // Only allow local URLs (starting with a single slash, not // or /\\)
        if (returnUrl && /^\/(?!\/|\\)/.test(returnUrl)) {
            var hash = window.location.hash;
            if (hash && hash !== '#')
                returnUrl += hash;
            window.location.href = returnUrl;
        } else {
            // Default to home page if returnUrl is not safe
            window.location.href = resolveUrl('~/');
        }
    }

    protected renderContents() {
        const id = this.useIdPrefix();
        this.element.empty().append(<>
            <AccountPanelTitle />
            <div class="s-Panel p-4">
                <h5 class="text-center my-4">{LoginFormTexts.LoginToYourAccount}</h5>
                <form id={id.Form} action="">
                    <div id={id.PropertyGrid}></div>
                    <div class="px-field">
                        <a class="float-end text-decoration-none" href={resolveUrl('~/Account/ForgotPassword')}>
                            {LoginFormTexts.ForgotPassword}
                        </a>
                    </div>
                    <div class="px-field">
                        <button id={id.LoginButton} type="submit" class="btn btn-primary my-3 w-100"
                            onClick={e => {
                                e.preventDefault();
                                this.loginClick();
                            }}>
                            {LoginFormTexts.SignInButton}
                        </button>
                    </div>
                </form>
            </div>
            <div class="text-center mt-2">
                <a class="text-decoration-none" href={resolveUrl('~/Account/SignUp')}>{LoginFormTexts.SignUpButton}</a>
            </div>
        </>);
    }
}