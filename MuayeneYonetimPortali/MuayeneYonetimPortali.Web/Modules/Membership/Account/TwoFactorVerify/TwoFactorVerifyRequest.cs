using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuayeneYonetimPortali.Modules.Membership.Account.TwoFactorVerify
{
    public class TwoFactorVerifyRequest
    {
        public int UserId { get; set; }
        public string Code { get; set; }
    }
}