using RestSharp;
using WorkShopApiTesting.src.end_points;

namespace WorkShopApiTesting.src
{
    public class ApiStatusCode : EndPointBase
    {
        
        public ApiStatusCode()
        {
            Init();
        }

        public override void Init()
        {
            url = "https://httpbin.org/status";
            client = new RestClient(url);
        }

        public IRestResponse Get(int statusCode)
        {
            var request = new RestRequest(statusCode.ToString(), Method.GET);
            return client.Execute(request);
        }

        public IRestResponse Delete(int statusCode)
        {
            var request = new RestRequest( statusCode.ToString(), Method.DELETE);
            return client.Execute(request);
        }

        public IRestResponse Patch(int statusCode)
        {
            var request = new RestRequest(statusCode.ToString(), Method.PATCH);
            return client.Execute(request);
        }

        public IRestResponse Post(int statusCode)
        {
            var request = new RestRequest(statusCode.ToString(), Method.POST);
            return client.Execute(request);
        }

        public IRestResponse Put(int statusCode)
        {
            var request = new RestRequest(statusCode.ToString(), Method.PUT);
            return client.Execute(request);
        }

       
    }
}
