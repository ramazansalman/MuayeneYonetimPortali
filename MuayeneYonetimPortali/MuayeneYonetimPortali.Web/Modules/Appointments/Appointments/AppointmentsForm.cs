using Serenity.ComponentModel;
using System;

namespace MuayeneYonetimPortali.Appointments.Forms;

[FormScript("Appointments.Appointments")]
[BasedOnRow(typeof(AppointmentsRow), CheckNames = true)]
public class AppointmentsForm
{
    [Tab("Muayene Yeri")]
    public int CityId { get; set; }
    public int DistrictId { get; set; }
    public int HospitalId { get; set; }
    public int DepartmentId { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }

    [Tab("Muayene Tarihi")]
    [Category("Tarih Seç")]
    [DateTimeEditor(IntervalMinutes =20), HalfWidth]
    public DateTime AppointmentDate { get; set; }
}