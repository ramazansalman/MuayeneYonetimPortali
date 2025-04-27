using Serenity.ComponentModel;
using System;

namespace MuayeneYonetimPortali.Examinations.Forms;

[FormScript("Examinations.Examinations")]
[BasedOnRow(typeof(ExaminationsRow), CheckNames = true)]
public class ExaminationsForm
{
    public int AppointmentId { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public string Complaint { get; set; }
    public DateTime ExaminationDate { get; set; }
    public string DoctorNote { get; set; }
}