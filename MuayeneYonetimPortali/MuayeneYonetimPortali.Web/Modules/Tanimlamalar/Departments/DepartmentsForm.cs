using Serenity.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Departments")]
[BasedOnRow(typeof(DepartmentsRow), CheckNames = true)]
public class DepartmentsForm
{
    public string Name { get; set; }
}