using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MELCloudAPILib
{
    public class ListDevices
    {
        public ListDevicesReply GetDevices(string token, Configuration config)
        {
            var headers = new Dictionary<string, string>() {
              { "X-MitsContextKey", token }
            };

            var devices = new Utilities().SendHTTPRequestAsGet("", config.BaseUrl + "/User/ListDevices", headers);

            if (devices == null)
            {
                return null;
            }

            ListDevicesReply reply = JsonConvert.DeserializeObject<ListDevicesReply>(devices.ToString());

            return reply;
        }

    }
}
