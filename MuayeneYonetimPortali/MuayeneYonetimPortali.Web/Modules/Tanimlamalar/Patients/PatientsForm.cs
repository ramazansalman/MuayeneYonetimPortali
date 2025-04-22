using Serenity.ComponentModel;
using System;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Patients")]
[BasedOnRow(typeof(PatientsRow), CheckNames = true)]
public class PatientsForm
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Gender { get; set; }
    public DateTime BirthDate { get; set; }
}