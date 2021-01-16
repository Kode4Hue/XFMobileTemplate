using RestSharp;
using System;
using System.Threading.Tasks;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;
using XfMobileTemplate.Ca.Application.Features.Common.Services;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Constants;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Utilities.Network;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Services
{
    public class JamaicaOpenDataService: BaseHttpService, IJamaicaOpenDataService
    {

        public JamaicaOpenDataService(ICustomHttpClientFactory httpClientFactory):base(httpClientFactory)
        {
            HttpClient.BaseUrl = new Uri($"{AppSettings.JamaicaOpenDataBaseAddress}action/datastore/search.json?");
        }
        public async Task<ResultDTO<PetrolPriceDTO>> GetPetrolPrices(int limit)
        {
            var request = BuildRequest($"resource_id=6aadb194-5452-4e7d-aa93-93db74361955&limit={limit}", Method.GET);
            return await RequestHelper<ResultDTO<PetrolPriceDTO>>.ExecuteRequest(HttpClient, request);
        }

    }
}
