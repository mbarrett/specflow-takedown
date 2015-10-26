using EasyHttp.Http;

namespace specflow_takedown.Contexts
{
    public static class HttpClientContext
    {
        public static HttpResponse Get(string uri)
        {
            var httpClient = new HttpClient();
            httpClient.Request.Accept = HttpContentTypes.ApplicationJson;

            return httpClient.Get(uri);
        }
    }
}
