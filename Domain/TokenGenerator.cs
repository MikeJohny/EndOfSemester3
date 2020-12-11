using System.Collections.Generic;
using System.Configuration;
using Twilio.Jwt.AccessToken;

namespace TwilioChat.Web.Domain
{
    public interface ITokenGenerator
    {
        string Generate(string identity);
    }

    public class TokenGenerator : ITokenGenerator
    {
        public string Generate(string identity)
        {
            var grants = new HashSet<IGrant>
            {
                new ChatGrant {ServiceSid = ConfigurationManager.AppSettings["TwilioChatService"]}
            };

            var token = new Token(
                ConfigurationManager.AppSettings["TwilioSid"],

        ConfigurationManager.AppSettings["TwilioChatSid"],
                ConfigurationManager.AppSettings["TwilioChatSecret"],
                identity,
                grants: grants);

            return token.ToJwt();
        }
    }
}
