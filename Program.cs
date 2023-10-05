using Newtonsoft.Json;
using System.Net.Http;
using System;

namespace apiConnection
{
    class Prgram
    {
        //getting the url api and save it in the "url" variable, so that i can use it later
        string url = "https://api.coinbase.com/v2/exchange-rates";

        //http client is used to be able to manage requests to server
        //to create a http client object do the next:
        HttpClient httpClient = new HttpClient();

        public async void Main(string[] args)//this main method uses "async" keyword. to specify them that Main method it is going to do async processess. If u dont specify that Main method will not do that.
        {
            //is a good practice to use the try and catch statment coz
            //countless issues could happen. So:
            try
            {
                //a request looks like:
                //that is known as a verbal
                var httpResponseMessage = await httpClient.GetAsync(url); //what is "await"? It is used to await the get async method to finish
                                                                          // but at the same time we dont want to freeze our application
                                                                          //We use it cuz we can't wait inside a non-asyn method.

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}