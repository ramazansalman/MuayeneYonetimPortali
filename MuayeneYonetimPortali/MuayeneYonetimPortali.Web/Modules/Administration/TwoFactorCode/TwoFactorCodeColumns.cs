using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Administration.Columns;

[ColumnsScript("Administration.TwoFactorCode")]
[BasedOnRow(typeof(TwoFactorCodeRow), CheckNames = true)]
public class TwoFactorCodeColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string Username { get; set; }
    [EditLink]
    public string Code { get; set; }
    public DateTime ExpireTime { get; set; }
}