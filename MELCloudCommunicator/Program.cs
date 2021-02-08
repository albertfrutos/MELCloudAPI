using System;
using MELCloudAPILib;
using Newtonsoft.Json.Linq;

namespace MELCloudCommunicator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var config = new Configuration();
            config.Language = (int)User.AvailableLanguages.ES;

            var email = "my_email";
            var password = "my_password";
            


            var token = new User().Login(email, password, config);

            
            Console.WriteLine("Token is: " + token);
            Console.ReadLine();
        }
    }
}
