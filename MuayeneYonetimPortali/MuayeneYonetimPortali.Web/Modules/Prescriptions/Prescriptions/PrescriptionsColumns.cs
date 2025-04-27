using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Prescriptions.Columns;

[ColumnsScript("Prescriptions.Prescriptions")]
[BasedOnRow(typeof(PrescriptionsRow), CheckNames = true)]
public class PrescriptionsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int PrescriptionId { get; set; }
    public string ExaminationComplaint { get; set; }
    public string DoctorName { get; set; }
    public string PatientName { get; set; }
    [EditLink]
    public string PrescriptionNote { get; set; }
    public DateTime PrescriptionDate { get; set; }
}