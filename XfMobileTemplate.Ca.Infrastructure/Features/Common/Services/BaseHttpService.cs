using RestSharp;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Services
{
    public class BaseHttpService
    {
        protected IRestClient HttpClient;
        public BaseHttpService(ICustomHttpClientFactory httpClientFactory)
        {
            HttpClient = httpClientFactory.GetInstance();
        }

        protected IRestRequest BuildRequest(string resource, Method method)
        {
            return new RestRequest(resource, method)
                .AddHeader("Content-Type", "application/json");
        }
    }
}
