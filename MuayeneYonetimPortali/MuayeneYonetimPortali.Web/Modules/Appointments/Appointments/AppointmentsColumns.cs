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
    public DateTime AppointmentDate { get; set; }
    public string CityName { get; set; }
    public string DistrictName { get; set; }
    public string HospitalName { get; set; }
    public string DepartmentName { get; set; }
    public string DoctorName { get; set; }
    public string PatientName { get; set; }
}