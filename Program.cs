using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Threading.Tasks;//lybrary we need to use if we want to use Task keyword

namespace apiConnection
{
    class Program
    {

        static async Task Main(string[] args)//this main method uses "async" keyword. to specify them that Main method it is going to do async processess.
                                             //If u dont specify that Main method will not do that. Also, "Task" is used to specify that Main method is going to return an async task.

        {
            //getting the url api and save it in the "url" variable, so that i can use it later
            string url = "https://api.coinbase.com/v2/exchange-rates";

            //http client is used to be able to manage requests to server
            //to create a http client object do the next:
            HttpClient httpClient = new HttpClient();

            //is a good practice to use the try and catch statment coz
            //countless issues could happen. So:
            try
            {
                //a request looks like:
                //that is known as a verbal
                var httpResponseMessage = await httpClient.GetAsync(url); //what is "await"? It is used to await the get async method to finish
                                                                          // but at the same time we dont want to freeze our application
                                                                          //We use it cuz we can't wait inside a non-asyn method.
                
                //we're awating to load the entire page that is gonna be saved in "httpResponseMessage", which
                //is not going to be the actual data.But now, we can get the data we want from the content of that response message.
                //To do thatm let's gonna read the string from the response content using:
                string jsonRespone = await httpResponseMessage.Content.ReadAsStringAsync();
                //then just print the result
                Console.WriteLine(jsonRespone);

                //Deserialize process: Converting json response into a c# array of type Post[] (the class we added w/ json data as c# properties)
                var myPost = JsonConvert.DeserializeObject<Rates[]>(jsonRespone);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
    }
}