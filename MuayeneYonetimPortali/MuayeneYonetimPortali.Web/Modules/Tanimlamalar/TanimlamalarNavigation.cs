using Serenity.Navigation;
using MyPages = MuayeneYonetimPortali.Tanimlamalar.Pages;

[assembly: NavigationMenu(7000, "Tanimlamalar", icon: "fa-notes-medical")]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/City", typeof(MyPages.CityPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Districts", typeof(MyPages.DistrictsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Hospitals", typeof(MyPages.HospitalsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Departments", typeof(MyPages.DepartmentsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Doctors", typeof(MyPages.DoctorsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Patients", typeof(MyPages.PatientsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Diagnoses", typeof(MyPages.DiagnosesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Drugs", typeof(MyPages.DrugsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tanimlamalar/Drugs", typeof(MyPages.DrugsPage), icon: null)]