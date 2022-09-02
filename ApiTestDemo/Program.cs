using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharpDemo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharpDemo.Models;

namespace ApiTestDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("/api/users?page=2");
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            RestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
            //var json = JsonConvert.DeserializeObject(content);
            //Console.WriteLine(json);
            //Console.ReadKey();



            //Method-2
            Users user = JsonConvert.DeserializeObject<Users>(content);
            foreach (var item in user.data)
            {
                
                Console.WriteLine(item.first_name);
                
            }
            

            var jobject = (JObject)JsonConvert.DeserializeObject(content);
            var jvalue = (JValue)jobject["page"];
            Console.WriteLine(jvalue.Value);
        }
    }
}
