using System;
namespace MELCloudAPILib
{
    public class Configuration
    {
        public string BaseUrl { get; set; } = "";
        public int Language { get; set; } = (int)Login.AvailableLanguages.EN;
    }
}
