using RestSharp;
using WorkShopApiTesting.src.end_points;

namespace WorkShopApiTesting.src
{
    public class Api : EndPointBase
    {
        public Api()
        {
            Init();
        }
        
        public override void Init()
        {
            url = "https://httpbin.org";
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
    }
}
