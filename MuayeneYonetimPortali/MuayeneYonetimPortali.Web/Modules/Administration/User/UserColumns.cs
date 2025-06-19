namespace MuayeneYonetimPortali.Administration.Columns;

[ColumnsScript("Administration.User")]
[BasedOnRow(typeof(UserRow), CheckNames = true)]
public class UserColumns
{
    [EditLink, AlignRight, Width(55)]
    public string UserId { get; set; }
    [EditLink, Width(150)]
    [QuickFilter, QuickSearch]
    public string Username { get; set; }
    [Width(150)]
    public string DisplayName { get; set; }
    [Width(250)]
    [QuickSearch]
    public string Email { get; set; }
    [Width(80)]
    public string Source { get; set; }
    [QuickFilter, QuickSearch, Width(300)]
    public string Roles { get; set; }
    [Width(100)]
    public string PhoneNumber { get; set; }
    [Width(100)]
    public string TwoFactorMethod { get; set; }
    [Width(50)]
    public Boolean TwoFactorEnabled { get; set; }
}
