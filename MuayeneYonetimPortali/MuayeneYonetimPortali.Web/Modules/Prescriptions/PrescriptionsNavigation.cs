using Serenity.Navigation;
using MyPages = MuayeneYonetimPortali.Prescriptions.Pages;

[assembly: NavigationMenu(6000, "Prescriptions", icon: "fa-prescription-bottle-alt")]
[assembly: NavigationLink(int.MaxValue, "Prescriptions/Prescriptions", typeof(MyPages.PrescriptionsPage), icon: null)]