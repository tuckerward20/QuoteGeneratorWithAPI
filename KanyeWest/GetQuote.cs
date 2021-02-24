using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class GetQuote
    {
        public static string SwansonQuote()
        {
            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var client = new HttpClient();

            var swansonResponse = client.GetStringAsync(swansonURL).Result;

            var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return swansonQuote;
        }

        public static string KanyeQuote()
        {
            var kanyeURL = "https://api.kanye.rest";

            var client = new HttpClient();

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

    }
}
