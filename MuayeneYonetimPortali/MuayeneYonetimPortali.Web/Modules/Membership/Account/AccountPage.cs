using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MuayeneYonetimPortali.Administration;
using MuayeneYonetimPortali.Modules.Administration.TwoFactorCode;
using MuayeneYonetimPortali.Membership;
using Serenity.Data;
using MuayeneYonetimPortali.Modules.Membership.Account.TwoFactorVerify;

namespace MuayeneYonetimPortali.Membership.Pages;

[Route("Account/[action]")]
public partial class AccountPage : Controller
{
    protected ITwoLevelCache Cache { get; }
    protected ITextLocalizer Localizer { get; }
    public AccountPage(ITwoLevelCache cache, ITextLocalizer localizer)
    {
        Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
        Cache = cache ?? throw new ArgumentNullException(nameof(cache));
    }

    [HttpGet]
    public ActionResult Login(int? denied, string activated, string returnUrl)
    {
        if (denied == 1)
            return View(MVC.Views.Errors.AccessDenied,
                ("~/Account/Login?returnUrl=" + Uri.EscapeDataString(returnUrl)));

        ViewData["Activated"] = activated;
        ViewData["HideLeftNavigation"] = true;
        return View(MVC.Views.Membership.Account.Login.LoginPage);
    }

    [HttpGet]
    public ActionResult AccessDenied(string returnURL)
    {
        ViewData["HideLeftNavigation"] = !User.IsLoggedIn();

        return View(MVC.Views.Errors.AccessDenied, (object)returnURL);
    }

    [HttpPost, JsonRequest]
    public Result<ServiceResponse> Login(LoginRequest request,
        [FromServices] IUserPasswordValidator passwordValidator,
        [FromServices] IUserClaimCreator userClaimCreator,
        [FromServices] ISqlConnections sqlConnections)
    {

        return this.ExecuteMethod<ServiceResponse>(() =>
        {
            if (request is null)
                throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.Username))
                throw new ArgumentNullException(nameof(request.Username));

            if (passwordValidator is null)
                throw new ArgumentNullException(nameof(passwordValidator));

            if (userClaimCreator is null)
                throw new ArgumentNullException(nameof(userClaimCreator));

            var username = request.Username;
            var result = passwordValidator.Validate(ref username, request.Password);
            if (result == PasswordValidationResult.Valid)
            {
                // Fetch user by username
                UserRow user;
                using (var connection = sqlConnections.NewFor<UserRow>())
                {
                    user = connection.TryFirst<UserRow>(UserRow.Fields.Username == username);
                }
                if (user == null)
                    throw new ValidationError("AuthenticationError", MembershipValidationTexts.AuthenticationError.ToString(Localizer));

                var twoFactorService = HttpContext.RequestServices.GetRequiredService<TwoFactorService>();
                twoFactorService.SendCode(user.UserId.Value, user.Email, "email");

                // Return a special error code to the client to redirect to 2FA page
                var returnUrl = Request.Query["returnUrl"].ToString();
                if (!string.IsNullOrEmpty(returnUrl) && !returnUrl.StartsWith("/") || returnUrl.StartsWith("//") || returnUrl.StartsWith(@"\"))
                    returnUrl = ""; // sanitize
                
                throw new ValidationError(
                    "RedirectUserTo", // error code
                    null,             // localizer/message (can be null)
                    "/Account/TwoFactorVerify?userId=" + user.UserId + (string.IsNullOrEmpty(returnUrl) ? "" : "&returnUrl=" + Uri.EscapeDataString(returnUrl))
                );
            }

            if (result == PasswordValidationResult.InactiveUser)
            {
                throw new ValidationError("InactivatedAccount", MembershipValidationTexts.AuthenticationError.ToString(Localizer));
            }

            throw new ValidationError("AuthenticationError", MembershipValidationTexts.AuthenticationError.ToString(Localizer));
        });
    }

    private ActionResult Error(string message)
    {
        return View(MVC.Views.Errors.ValidationError, new ValidationError(message));
    }

    public string KeepAlive()
    {
        return "OK";
    }

    public ActionResult Signout()
    {
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        HttpContext.RequestServices.GetService<IElevationHandler>()?.DeleteToken();
        return new RedirectResult("~/");
    }

    [HttpGet]
    public ActionResult TwoFactorVerify(int userId)
    {
        ViewData["UserId"] = userId;
        ViewData["HideLeftNavigation"] = true;
        return View("~/Modules/Membership/Account/TwoFactorVerify/TwoFactorVerifyPage.cshtml");
        }

    [HttpPost, JsonRequest]
    public Result<ServiceResponse> TwoFactorVerify(
        TwoFactorVerifyRequest request,
        [FromServices] TwoFactorService twoFactorService,
        [FromServices] IUserClaimCreator userClaimCreator,
        [FromServices] ISqlConnections sqlConnections)
    {
        return this.ExecuteMethod<ServiceResponse>(() =>
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (twoFactorService.VerifyCode(request.UserId, request.Code))
            {
                // Fetch user by userId
                UserRow user;
                using (var connection = sqlConnections.NewFor<UserRow>())
                {
                    user = connection.TryFirst<UserRow>(UserRow.Fields.UserId == request.UserId);
                }
                if (user == null)
                    throw new ValidationError("AuthenticationError", "User not found.");

                var principal = userClaimCreator.CreatePrincipal(user.Username, authType: "Password");
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).GetAwaiter().GetResult();
                return new ServiceResponse();
            }
            throw new ValidationError("Invalid2FACode", "Invalid or expired 2FA code.");
        });
    }
}