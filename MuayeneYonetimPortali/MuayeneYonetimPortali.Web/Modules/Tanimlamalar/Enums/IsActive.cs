namespace MuayeneYonetimPortali.Tanimlamalar;

[EnumKey("Tanimlamalar.IsActive")]
public enum IsActive
{
    [Description("Pasif")]
    Pasif = 0,
    [Description("Aktif")]
    Aktif = 1,
    [Description("Silinmiş")]
    Silinmis = 2
}