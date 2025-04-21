using Serenity.Navigation;
using MyPages = MuayeneYonetimPortali.Tanimlamalar.Pages;

[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/City", typeof(MyPages.CityPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Districts", typeof(MyPages.DistrictsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Hospitals", typeof(MyPages.HospitalsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Departments", typeof(MyPages.DepartmentsPage), icon: null)]