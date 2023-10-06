# apiConnection2
This project of an API procedure has more efficient workflows. 

It is a C# program that uses the 'Newtonsoft.Json' library to read a JSON response from an API. The API in this case is the Coinbase exchange rate API. Available at: https://docs.cloud.coinbase.com/sign-in-with-coinbase/docs/api-exchange-rates

The program starts by creating a new HttpClient object. This object is used to make HTTP requests to the API. Next, the program makes a GET request to the API's exchange rate endpoint. The response from the API is saved in a variable called httpResponseMessage.

The program then uses the await keyword to wait for the response to be received. This is important because the GetAsync method is an asynchronous method, which means that it returns immediately and does not wait for the response to be received. The await keyword allows the program to continue executing without blocking the main thread.

Once the response has been received, the program uses the Content.ReadAsStringAsync method to read the response body as a string. The response body is in JSON format, so the program then uses the Newtonsoft.Json library to deserialize the JSON into a C# object.

Finally, the program prints the deserialized object to the console.

Here is a more detailed explanation of some of the key concepts in the code:

* **Asynchronous programming:** Asynchronous programming is a type of programming that allows multiple tasks to be executed simultaneously. This can be useful for improving the performance of applications that need to perform long-running tasks, such as making HTTP requests.
* **The await keyword:** The await keyword is used to wait for an asynchronous operation to complete. It is typically used in conjunction with the async keyword, which is used to mark a method as asynchronous.
* **Newtonsoft.Json:** Newtonsoft.Json is a popular JSON library for C#. It can be used to serialize and deserialize JSON objects to and from C# objects.

Overall, the code provided is a simple example of how to use Newtonsoft.Json to read a JSON response from an API. The same principles can be used to read JSON responses from any API.
