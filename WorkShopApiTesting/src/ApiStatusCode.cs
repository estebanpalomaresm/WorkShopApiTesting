using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShopApiTesting.src
{
    public class ApiStatusCode
    {
        private string url = "https://httpbin.org";
        private RestClient client;

        public ApiStatusCode()
        {
            client = new RestClient(url);
        }
        public IRestResponse Get(int statusCode)
        {
            var request = new RestRequest($"/status/"+statusCode, Method.GET);
            return client.Execute(request);
        }
        public IRestResponse Delete(int statusCode)
        {
            var request = new RestRequest($"/status/" + statusCode, Method.DELETE);
            return client.Execute(request);
        }
        public IRestResponse Patch(int statusCode)
        {
            var request = new RestRequest($"/status/"+statusCode, Method.PATCH);
            return client.Execute(request);
        }
        public IRestResponse Post(int statusCode)
        {
            var request = new RestRequest($"/status/"+statusCode, Method.POST);
            return client.Execute(request);
        }
        public IRestResponse Put(int statusCode)
        {
            var request = new RestRequest($"/status/"+statusCode, Method.PUT);
            return client.Execute(request);
        }
    }
}
