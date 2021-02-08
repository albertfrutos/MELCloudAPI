using System;
using Newtonsoft.Json.Linq;

namespace MELCloudAPILib
{
    public class Login
    {
        public string AppVersion {get; set;} = "1.9.3.0";
        public string CaptchaChallenge { get; set; } = "";
        public string CaptchaResponse { get; set; } = "";

        public string Email { get; set; }
        public string Password { get; set; }


        public int Language { get; set; }
        public bool Persist { get; set; } = true;

        public enum AvailableLanguages
        {
            EN = 0,  // English
            BG = 1,  // Bulgarian
            CS = 2,  // Czech
            DA = 3,  // Danish
            DE = 4,  // German
            ET = 5,  // Estonian
            ES = 6,  // Spanish
            FR = 7,  // French
            HY = 8,  // Armenian
            LV = 9,  // Latvian
            LT = 10,  // Lithuanian
            HU = 11,  // Hungarian
            NL = 12,  // Dutch
            NO = 13,  // Norwegian
            PL = 14,  // Polish
            PT = 15,  // Portuguese
            RU = 16,  // Russian
            FI = 17,  // Finnish
            SV = 18,  // Swedish
            IT = 19,  // Italian
            UK = 20,  // Ukrainian
            TR = 21,  // Turkish
            EL = 22,  // Greek
            HR = 23,  // Croatian
            RO = 24,  // Romanian
            SL = 25,  // Slovenian
        }

        public string UserLogin(string email, string password, Configuration config)
        {
            var user = new Login
            {
                Email = email,
                Password = password,
                Language = config.Language
            };

            var response = new Utilities().SendHTTPRequestAsPost(user, config.BaseUrl + "/Login/Client.Login");

            if (!String.IsNullOrEmpty(response["ErrorId"].ToString()))
            {
                return null;
            }

            var token = GetUserToken(response.ToString()); 
            return token;
        }
        

        public string GetUserToken(string json)
        {
            var token = JObject.Parse(json);
            return token["LoginData"]["ContextKey"].ToString();
        }
    }
}
