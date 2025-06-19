import { resolveUrl, serviceCall, parseQueryString } from "@serenity-is/corelib";

export default function pageInit(opt?: { userId: number }) {
    const panel = document.getElementById("TwoFactorPanel");
    if (!panel) return;

    panel.innerHTML = `
        <h5 class="text-center my-4">Enter the code sent to your email</h5>
        <form id="TwoFactorForm">
            <input type="hidden" id="UserId" value="${opt?.userId ?? ""}" />
            <div class="mb-3">
                <input type="text" id="Code" class="form-control" placeholder="2FA Code" autocomplete="off" />
            </div>
            <button type="submit" class="btn btn-primary w-100">Verify</button>
        </form>
        <div id="TwoFactorError" class="text-danger mt-2" style="display:none"></div>
    `;

    const form = panel.querySelector("#TwoFactorForm") as HTMLFormElement;
    form.onsubmit = function (e) {
        e.preventDefault();
        const userId = (panel.querySelector("#UserId") as HTMLInputElement).value;
        const code = (panel.querySelector("#Code") as HTMLInputElement).value;

        serviceCall({
            url: resolveUrl("~/Account/TwoFactorVerify"),
            request: { userId: Number(userId), code },
            onSuccess: () => {
                // Securely handle returnUrl
                const q = parseQueryString();
                const returnUrl = q['returnUrl'];
                if (returnUrl && /^\/(?!\/|\\)/.test(returnUrl)) {
                    window.location.href = returnUrl;
                } else {
                    window.location.href = resolveUrl("~/");
                }
            },
            onError: response => {
                const errDiv = panel.querySelector("#TwoFactorError") as HTMLDivElement;
                errDiv.innerText = response?.Error?.Message || "Invalid or expired code.";
                errDiv.style.display = "";
            }
        });
    };
}