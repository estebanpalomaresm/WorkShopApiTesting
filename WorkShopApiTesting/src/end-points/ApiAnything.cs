using RestSharp;

namespace WorkShopApiTesting.src.end_points
{
    public class ApiAnything : EndPointBase
    {
        public ApiAnything()
        {
            Init();
        }

        public override void Init()
        {
            url = "https://httpbin.org/anything";
            client = new RestClient(url);
        }

        public IRestResponse Post(string jsonString)
        {
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(jsonString);
            return client.Execute(request);
        }

        public IRestResponse Delete(string jsonString)
        {
            var request = new RestRequest(Method.DELETE);
            request.AddJsonBody(jsonString);
            return client.Execute(request);
        }

        public IRestResponse Get(string jsonString)
        {
            var request = new RestRequest(Method.GET);
            return client.Execute(request);
        }

        public IRestResponse Patch(string jsonString)
        {
            var request = new RestRequest(Method.PATCH);
            request.AddJsonBody(jsonString);
            return client.Execute(request);
        }

        public IRestResponse Put(string jsonString)
        {
            var request = new RestRequest(Method.PUT);
            request.AddJsonBody(jsonString);
            return client.Execute(request);
        }
    }
}
