using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serenity.Extensions;
using Serenity.Data;
using MimeKit;
using MuayeneYonetimPortali.Administration;

namespace MuayeneYonetimPortali.Modules.Administration.TwoFactorCode
{
    public class TwoFactorService
    {
        private readonly IEmailSender emailSender;
        private readonly ISqlConnections sqlConnections;


        public TwoFactorService(IEmailSender emailSender, ISqlConnections sqlConnections)
        {
            this.emailSender = emailSender;
            this.sqlConnections = sqlConnections;
        }

        public void SendCodeByEmail(string email, string code)
        {
            var message = new MimeMessage();
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "Your 2FA Code";
            message.Body = new TextPart("plain") { Text = $"Your code is: {code}" };

            emailSender.Send(message, skipQueue: false);
        }

        public void SendCode(int userId, string email, string method)
        {
            if (method?.ToLowerInvariant() == "email" && !string.IsNullOrEmpty(email))
            {
                string code = GenerateTwoFactorCode();
                SendCodeByEmail(email, code);
                Console.WriteLine($"2FA code sent to {email}: {code}");

                // Store the code in the database
                using (var connection = sqlConnections.NewFor<TwoFactorCodeRow>())
                {
                    var row = new MuayeneYonetimPortali.Administration.TwoFactorCodeRow
                    {
                        UserId = userId,
                        Code = code,
                        ExpireTime = DateTime.UtcNow.AddSeconds(30)
                    };
                    connection.Insert(row);
                }
            }
            else
            {
                throw new NotSupportedException("Only email 2FA is supported currently.");
            }
        }

        public static string GenerateTwoFactorCode()
        {
            Random random = new Random();
            string code;

            do
            {
                code = random.Next(0, 1000000).ToString("D6");
            } while (IsInvalidCode(code));

            return code;
        }

        private static bool IsInvalidCode(string code)
        {
            // Check if the code has 3 or more consecutive identical digits
            for (int i = 0; i < code.Length - 2; i++)
            {
                if (code[i] == code[i + 1] && code[i] == code[i + 2])
                {
                    return true;
                }
            }

            // Check if the code starts with '000' or '111'
            if (code.StartsWith("000") || code.StartsWith("111"))
            {
                return true;
            }

            return false;
        }

        public bool VerifyCode(int userId, string inputCode)
        {
            using (var connection = sqlConnections.NewFor<TwoFactorCodeRow>())
            {
                var row = connection.TrySingle<TwoFactorCodeRow>(
                    TwoFactorCodeRow.Fields.UserId == userId &
                    TwoFactorCodeRow.Fields.Code == inputCode &
                    TwoFactorCodeRow.Fields.ExpireTime > DateTime.UtcNow);

                if (row != null)
                {
                    connection.DeleteById<TwoFactorCodeRow>(row.Id);
                    return true;
                }
            }
            return false;
        }
    }
}