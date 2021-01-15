using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Arrays
{
    public static class Asynchronous
    {
        public static string GetHttpClient()
        {
            var httpClient = new HttpClient();
            var myTask = httpClient.GetStringAsync("https://ObiOberoi.com");
            var myString = myTask.GetAwaiter().GetResult();
            return myString;
        }
    }
}
