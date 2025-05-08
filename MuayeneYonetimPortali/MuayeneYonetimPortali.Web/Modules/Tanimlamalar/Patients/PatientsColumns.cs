using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Patients")]
[BasedOnRow(typeof(PatientsRow), CheckNames = true)]
public class PatientsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
    public int PatientId { get; set; }
    public string Username { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Tckn { get; set; }
    public IsActive IsActive {get; set; }
}