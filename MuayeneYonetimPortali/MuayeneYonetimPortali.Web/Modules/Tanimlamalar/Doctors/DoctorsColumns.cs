using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Doctors")]
[BasedOnRow(typeof(DoctorsRow), CheckNames = true)]
public class DoctorsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int DoctorId { get; set; }
    [EditLink]
    public string Username { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string HospitalName { get; set; }
    public string DepartmentName { get; set; }
}