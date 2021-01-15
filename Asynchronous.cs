using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Arrays
{
    public static class Asynchronous
    {
        /*
         * In the above code snippet .NET's HttpClient class is returning a Task instance, 
         * but we're calling GetAwaiter().GetResult() on the task, which is a blocking call. 
         * Again, this is synchronous; no execution will take place on the current thread until 
         * GetResult returns with the data returned by the operation (the requested string data in this example). 
         * Similarly, a task's Result property also blocks synchronously until data is returned.
         */
        public static string GetHttpClient()
        {
            var httpClient = new HttpClient();
            var myTask = httpClient.GetStringAsync("https://ObiOberoi.com");
            var myString = myTask.GetAwaiter().GetResult();
            return myString;
        }
    }
}
