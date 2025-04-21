using Serenity.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.City")]
[BasedOnRow(typeof(CityRow), CheckNames = true)]
public class CityForm
{
    public string Name { get; set; }
}