using Serenity.Navigation;
using MyPages = MuayeneYonetimPortali.Examinations.Pages;

[assembly: NavigationMenu(5000, "Examinations", icon: "fa-file-medical")]
[assembly: NavigationLink(int.MaxValue, "Examinations/Examinations", typeof(MyPages.ExaminationsPage), icon: null)]