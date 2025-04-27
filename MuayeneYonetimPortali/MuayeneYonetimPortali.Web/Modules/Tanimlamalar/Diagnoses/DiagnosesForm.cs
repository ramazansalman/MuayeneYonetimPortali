using Serenity.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Diagnoses")]
[BasedOnRow(typeof(DiagnosesRow), CheckNames = true)]
public class DiagnosesForm
{
    public string Code { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}