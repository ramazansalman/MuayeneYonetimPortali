using MuayeneYonetimPortali.Tanimlamalar;
using Serenity.ComponentModel;
using System;

namespace MuayeneYonetimPortali.Prescriptions.Forms;

[FormScript("Prescriptions.Prescriptions")]
[BasedOnRow(typeof(PrescriptionsRow), CheckNames = true)]
public class PrescriptionsForm
{
    public int ExaminationId { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public string PrescriptionNote { get; set; }
    public DateTime PrescriptionDate { get; set; }
    
    [LookupEditor(typeof(DrugsRow), Multiple = true)]
    public List<int> DrugList { get; set; }

}