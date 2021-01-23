using System;
using System.Net.Http;
using System.Threading.Tasks;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;
using XfMobileTemplate.Ca.Application.Features.Common.Services;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Constants;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Utilities.Network;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Services
{
    public class JamaicaOpenDataService : BaseHttpService, IJamaicaOpenDataService
    {

        public JamaicaOpenDataService(ICustomHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            HttpClient.BaseAddress = new Uri($"{AppSettings.JamaicaOpenDataBaseAddress}action/datastore/");
        }
        public async Task<ResultDTO<PetrolPriceDTO>> GetPetrolPrices(int limit)
        {
            var resourceId = "6aadb194-5452-4e7d-aa93-93db74361955";
            var requestPath = $"search.json?resource_id={resourceId}&limit={limit}";

            var requestMessage = GenerateHttpRequest(HttpMethod.Get, requestPath);
            var responseMessage = await MakeRequest(requestMessage);
            var deserializedContent = await HttpClientContentHelper<ResponseContentDTO<PetrolPriceDTO>>
                .DeserializeObjectFromHttpContent(responseMessage.Content);

            return deserializedContent.Result;
        }

    }
}
