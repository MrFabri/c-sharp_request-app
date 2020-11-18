// Simple terminal app

using System;
using System.Net;
using Newtonsoft.Json;

namespace getrequest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();

            string API_URL = "https://jsonplaceholder.typicode.com/posts?_limit=5";

            var data = client.DownloadString(API_URL);
            dynamic posts = JsonConvert.DeserializeObject(data);

            foreach(var post in posts) {
                Console.WriteLine(post.id + ": " + post.title);
            }
        }
    }
}