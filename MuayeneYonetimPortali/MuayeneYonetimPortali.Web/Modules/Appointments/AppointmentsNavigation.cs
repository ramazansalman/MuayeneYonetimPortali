﻿using Serenity.Navigation;
using MyPages = MuayeneYonetimPortali.Appointments.Pages;

[assembly: NavigationMenu(4000, "Appointments", icon: "fa-book")]
[assembly: NavigationLink(int.MaxValue, "Appointments/Appointments", typeof(MyPages.AppointmentsPage), icon: null)]