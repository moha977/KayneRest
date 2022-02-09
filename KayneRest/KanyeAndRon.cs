using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KayneRest
{
    public class KanyeAndRon
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine("----------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine("----------------");

        }
        public static void RonQuote()
        {
            var Client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = Client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


            Console.WriteLine("----------------");
            Console.WriteLine($"Ron Says: '{ronQuote}'");
            Console.WriteLine("----------------");
        }
    }
}
