using RestSharp;
using System.Threading.Tasks;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Utilities.Network
{
    public static class RequestHelper<T>
    {
        public static async Task<T> ExecuteRequest(IRestClient httpClient,
            IRestRequest request)
        {
            var response =  await httpClient.ExecuteAsync<T>(request);
            if (!response.IsSuccessful)
                return default(T);
                //throw new HttpErrorException(response.ErrorException);
            return response.Data;
        }
    }
}
