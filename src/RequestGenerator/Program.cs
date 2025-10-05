using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

var random = new Random();
var client = new HttpClient();
var requests = new List<Func<Task>>
{
    () => client.GetAsync("http://apple-api:5000/GetFruit"),
    () => client.PostAsync("http://apple-api:5000/PostFruit", default),
    () => client.GetAsync("http://banana-api:5000/GetFruit"),
    () => client.PostAsync("http://banana-api:5000/PostFruit", default)
};

while (true)
{
    try
    {
        await requests[random.Next(requests.Count)]();
    }
    catch
    {
        await Task.Delay(random.Next(1000));
    }
}
