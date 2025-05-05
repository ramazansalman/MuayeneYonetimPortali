using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Appointments.Columns;

[ColumnsScript("Appointments.Appointments")]
[BasedOnRow(typeof(AppointmentsRow), CheckNames = true)]
public class AppointmentsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId")]
    public int AppointmentId { get; set; }
    [DateTimeFormatter(DisplayFormat = "dd/MM/yyyy HH:mm"), Width(120)]
    [EditLink]
    public DateTime AppointmentDate { get; set; }
    [EditLink][Width(100)]
    public string CityName { get; set; }
    [EditLink][Width(80)]
    public string DistrictName { get; set; }
    [EditLink]
    public string HospitalName { get; set; }
    [EditLink]    
    public string DepartmentName { get; set; }
    // [EditLink]
    // public string DoctorName { get; set; }
    [EditLink][Width(120)]
    public string DoctorFullName { get; set; }
    // [EditLink]
    // public string PatientName { get; set; }
    [EditLink][Width(120)]
    public string PatientFullName { get; set; }
}