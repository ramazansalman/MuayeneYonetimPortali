using Serenity.ComponentModel;
using System;

namespace MuayeneYonetimPortali.Administration.Forms;

[FormScript("Administration.TwoFactorCode")]
[BasedOnRow(typeof(TwoFactorCodeRow), CheckNames = true)]
public class TwoFactorCodeForm
{
    public int UserId { get; set; }
    public string Code { get; set; }
    public DateTime ExpireTime { get; set; }
}