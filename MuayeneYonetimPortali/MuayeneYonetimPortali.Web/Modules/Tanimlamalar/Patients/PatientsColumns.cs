using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Patients")]
[BasedOnRow(typeof(PatientsRow), CheckNames = true)]
public class PatientsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int PatientId { get; set; }
    public string Username { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
}