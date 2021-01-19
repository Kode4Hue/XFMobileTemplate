using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Utilities.Network
{
    public static class RequestHelper<T>
    {
        public static async Task<T> ExecuteRequest(IRestClient httpClient,
            IRestRequest request)
        {

            // request.expec
            //httpClient.ConfigureWebRequest(r => r.KeepAlive = true);
            var response =  await httpClient.ExecuteAsync(request);
            if (!response.IsSuccessful)
                return default(T);
                //throw new HttpErrorException(response.ErrorException);
            return JsonConvert.DeserializeObject<T>( response.Content);
        }
    }
}
