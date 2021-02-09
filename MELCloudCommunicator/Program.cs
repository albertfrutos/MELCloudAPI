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

            var loginReply = new Login().UserLogin(email, password, config);

            if (loginReply == null)
            {
                Console.WriteLine("There was a problem while loggin in...");
                return;
            }

            var token = new LoginReply().GetToken(loginReply);

            if (String.IsNullOrEmpty(token)) {
                Console.WriteLine("ERROR: Token could not be acquired.");
                return;
            }

            Console.WriteLine("Token is: " + token);


            var devicesList = new ListDevices().GetDevices(token, config);



            Console.ReadLine();
        }
    }
}