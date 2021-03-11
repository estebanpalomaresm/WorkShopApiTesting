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
    }
}
