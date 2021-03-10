using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace WorkShopApiTesting.src
{
    public class Api
    {
        private string url = "https://httpbin.org";
        private RestClient client;

        public Api()
        {
            client = new RestClient(url);
        }

        public void GetIp()
        {

        }

        public IRestResponse Get()
        {
            var request = new RestRequest($"/get",Method.GET);
            return client.Execute(request);
        }
        public IRestResponse Delete()
        {
            var request = new RestRequest($"/delete",Method.DELETE);
            return client.Execute(request);
        }
        public IRestResponse Patch()
        {
            var request = new RestRequest($"/patch", Method.PATCH);
            return client.Execute(request);
        }
        public IRestResponse Post()
        {
            var request = new RestRequest($"/post", Method.POST);
            return client.Execute(request);
        }
        public IRestResponse Put()
        {
            var request = new RestRequest($"/put", Method.PUT);
            return client.Execute(request);
        }
        public IRestResponse GetSc()
        {
            var request = new RestRequest($"/status/200", Method.GET);
            return client.Execute(request);
        }
        public IRestResponse DeleteSc()
        {
            var request = new RestRequest($"/status/200", Method.DELETE);
            return client.Execute(request);
        }
        public IRestResponse PatchSc()
        {
            var request = new RestRequest($"/status/200", Method.PATCH);
            return client.Execute(request);
        }
        public IRestResponse PostSc()
        {
            var request = new RestRequest($"/status/200", Method.POST);
            return client.Execute(request);
        }
        public IRestResponse PutSc()
        {
            var request = new RestRequest($"/status/200", Method.PUT);
            return client.Execute(request);
        }
    }
}
