using Serenity.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Drugs")]
[BasedOnRow(typeof(DrugsRow), CheckNames = true)]
public class DrugsForm
{
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public string Barcode { get; set; }
    public string CompanyName { get; set; }
    public string AtcCode { get; set; }
    public string AtcName { get; set; }
}