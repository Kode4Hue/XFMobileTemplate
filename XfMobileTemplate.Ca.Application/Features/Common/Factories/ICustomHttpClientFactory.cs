using RestSharp;

namespace XfMobileTemplate.Ca.Application.Features.Common.Factories
{
    public interface ICustomHttpClientFactory
    {
        IRestClient GetInstance();
        void SetBaseAddress(string baseUrl);
    }
}
