using Serenity.Navigation;
using MyPages = MuayeneYonetimPortali.Administration.Pages;
using Administration = MuayeneYonetimPortali.Administration.Pages;

[assembly: NavigationMenu(9000, "Administration", icon: "fa-wrench")]
[assembly: NavigationLink(9100, "Administration/Languages", typeof(Administration.LanguagePage), icon: "fa-comments")]
[assembly: NavigationLink(9200, "Administration/Translations", typeof(Administration.TranslationPage), icon: "fa-comment-o")]
[assembly: NavigationLink(9300, "Administration/Roles", typeof(Administration.RolePage), icon: "fa-lock")]
[assembly: NavigationLink(9400, "Administration/User Management", typeof(Administration.UserPage), icon: "fa-users")]
[assembly: NavigationLink(9500, "Administration/Two Factor Code", typeof(Administration.TwoFactorCodePage), icon: "user-shield")]