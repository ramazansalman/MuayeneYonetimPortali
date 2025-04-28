using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Prescriptions.Columns;

[ColumnsScript("Prescriptions.Prescriptions")]
[BasedOnRow(typeof(PrescriptionsRow), CheckNames = true)]
public class PrescriptionsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId")]
    public int PrescriptionId { get; set; }
    [EditLink]
    public string ExaminationComplaint { get; set; }
    [EditLink]
    public string DoctorName { get; set; }
    [EditLink]
    public string PatientName { get; set; }
    [EditLink]
    public string PrescriptionNote { get; set; }
    [EditLink]
    public DateTime PrescriptionDate { get; set; }
    [Width(250), DrugListFormatter, EditLink]
    public List<int> DrugList { get; set; }
}