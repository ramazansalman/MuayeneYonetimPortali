using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Examinations.Columns;

[ColumnsScript("Examinations.Examinations")]
[BasedOnRow(typeof(ExaminationsRow), CheckNames = true)]
public class ExaminationsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId")]
    public int ExaminationId { get; set; }
    [EditLink]
    public int AppointmentId { get; set; }
    [EditLink]
    public string DoctorName { get; set; }
    [EditLink]
    public string PatientName { get; set; }
    [EditLink]
    public string Complaint { get; set; }
    [EditLink]
    public DateTime ExaminationDate { get; set; }
    [EditLink]
    public string DoctorNote { get; set; }
}