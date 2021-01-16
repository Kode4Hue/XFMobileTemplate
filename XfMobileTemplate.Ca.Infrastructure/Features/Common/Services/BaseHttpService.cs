using RestSharp;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;
using XfMobileTemplate.Ca.Application.Features.Common.Services;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Services
{
    public class BaseHttpService: IBaseHttpService
    {
        protected IRestClient HttpClient;
        public BaseHttpService(ICustomHttpClientFactory httpClientFactory)
        {
            HttpClient = httpClientFactory.GetInstance();
        }

        protected IRestRequest BuildRequest(string resource, Method method)
        {
            throw new System.NotImplementedException();
        }
    }
}
