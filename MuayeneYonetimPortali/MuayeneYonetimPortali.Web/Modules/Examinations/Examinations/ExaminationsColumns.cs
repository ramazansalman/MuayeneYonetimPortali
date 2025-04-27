using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Examinations.Columns;

[ColumnsScript("Examinations.Examinations")]
[BasedOnRow(typeof(ExaminationsRow), CheckNames = true)]
public class ExaminationsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int ExaminationId { get; set; }
    public int AppointmentId { get; set; }
    public string DoctorName { get; set; }
    public string PatientName { get; set; }
    [EditLink]
    public string Complaint { get; set; }
    public DateTime ExaminationDate { get; set; }
    public string DoctorNote { get; set; }
}