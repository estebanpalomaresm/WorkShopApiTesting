using RestSharp;

namespace WorkShopApiTesting.src.end_points
{
    public abstract class EndPointBase
    {
        protected string url;
        protected RestClient client;

        public abstract void Init();
        
    }
}
