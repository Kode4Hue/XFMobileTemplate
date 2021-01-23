using System.Net.Http;

namespace XfMobileTemplate.Ca.Application.Features.Common.Factories
{
    public interface ICustomHttpClientFactory
    {
        HttpClient GetInstance();
    }
}
