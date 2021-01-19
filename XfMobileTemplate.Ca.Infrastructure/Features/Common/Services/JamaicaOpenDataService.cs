using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;
using XfMobileTemplate.Ca.Application.Features.Common.Services;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Constants;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Services
{
    public class JamaicaOpenDataService: BaseHttpService, IJamaicaOpenDataService
    {

        public JamaicaOpenDataService(ICustomHttpClientFactory httpClientFactory):base(httpClientFactory)
        {
            HttpClient.BaseUrl = new Uri($"{AppSettings.JamaicaOpenDataBaseAddress}action/datastore/");
        }
        public async Task<ResultDTO<PetrolPriceDTO>> GetPetrolPrices(int limit)
        {

            try
            {

                var resourceId = "6aadb194-5452-4e7d-aa93-93db74361955";
                IRestRequest request = new RestRequest
                {
                    Method = Method.GET
                };

                request
                    .AddParameter("resource_id",resourceId);
                request.AddParameter("limit", limit);
                HttpClient.BaseUrl = new Uri($"{HttpClient.BaseUrl}search.json");
                var response = await HttpClient.ExecuteGetAsync(request);

                //.GetAsync<ResponseContentDTO<PetrolPriceDTO>>(request);
                var responseContent = JsonConvert.DeserializeObject<ResponseContentDTO<PetrolPriceDTO>>(response.Content);
                return responseContent.Result;
                //return response.Result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

                //RequestHelper<ResultDTO<PetrolPriceDTO>>.ExecuteRequest(HttpClient, request);
        }

    }
}
