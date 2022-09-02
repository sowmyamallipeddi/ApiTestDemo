using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharpDemo.Models;

namespace RestSharpDemo
{
    public class Demo
    {
        public Users GetUsers()
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("/api/users?page=2", Method.Get);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            RestResponse response = client.Execute(request);
            var content = response.Content;
            Users user = JsonConvert.DeserializeObject<Users>(content);
            return user;
          
        }
    }
}
