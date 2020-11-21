using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace YTB_Downloader
{
    public static class Youtube
    {
        public static async Task<dynamic> GetVideoInfo(string id)
        {
            var parameters = new Dictionary<string, string>
            {
                ["key"] = Credentials.YTApiKey,
                ["id"] = id,
                ["part"] = "snippet",
            };

            var baseUrl = "https://www.googleapis.com/youtube/v3/videos?";
            var fullUrl = MakeUrl(baseUrl, parameters);

            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(fullUrl).ConfigureAwait(false);

            if (result != null)
            {
                return JsonConvert.DeserializeObject(result);
            }

            return default(dynamic);
        }

        private static string MakeUrl(string baseUrl, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            if (string.IsNullOrWhiteSpace(baseUrl))
            {
                return "";
            }
            return parameters.Aggregate(baseUrl, (accumulated, kvp) => string.Format($"{accumulated}{kvp.Key}={kvp.Value}&"));
        }
    }
}