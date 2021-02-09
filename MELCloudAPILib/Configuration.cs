using System;
namespace MELCloudAPILib
{
    public class Configuration
    {
        public string BaseUrl { get; set; } = "https://ac65baf3-695b-4491-b697-d3f8b6732eb8.mock.pstmn.io";
        public int Language { get; set; } = (int)Login.AvailableLanguages.EN;
    }
}
