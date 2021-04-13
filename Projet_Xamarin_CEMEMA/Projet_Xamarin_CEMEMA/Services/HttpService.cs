using System.Net.Http;

namespace Projet_Xamarin_CEMEMA.Services
{
    public static class HttpService
    {
        static HttpClient client;

        public static HttpClient GetInstance()
        {
            if (client == null)
            {
                client = new HttpClient();
            }
            return client;
        }
    }
}