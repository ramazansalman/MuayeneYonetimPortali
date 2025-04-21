using Serenity.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Districts")]
[BasedOnRow(typeof(DistrictsRow), CheckNames = true)]
public class DistrictsForm
{
    public string Name { get; set; }
    public int CityId { get; set; }
}