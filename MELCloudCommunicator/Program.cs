using System;
using System.Collections.Generic;
using MELCloudAPILib;
using Newtonsoft.Json.Linq;

namespace MELCloudCommunicator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var config = new Configuration();
            config.Language = (int)Login.AvailableLanguages.EN;

            var email = "my_email";
            var password = "my_password";

            var token = new Login().UserLogin(email, password, config);
            var headers = new Dictionary<string, string>() {
              { "X-MitsContextKey", token }
            };
            var devices = new Utilities().SendHTTPRequestAsGet("", config.BaseUrl + "/User/ListDevices", headers);

            Console.WriteLine("Token is: " + token);

            Console.ReadLine();
        }
    }
}