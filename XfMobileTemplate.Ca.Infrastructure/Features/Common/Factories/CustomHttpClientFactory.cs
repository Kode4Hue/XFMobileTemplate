using Newtonsoft.FluentAPI.Resolvers;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;
using XfMobileTemplate.Ca.Infrastructure.Features.Petrol;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Factories
{
    public class CustomHttpClientFactory: ICustomHttpClientFactory
    {
        public IRestClient GetInstance()
        {
            var httpClient = new RestClient()
            {
                ThrowOnAnyError = true
            };

            ConfigureHttpClientProxy(httpClient);
            ConfigureSerializationSettings(httpClient);

            return httpClient;
        }

        private void ConfigureHttpClientProxy(IRestClient httpClient)
        {
            if (httpClient is not null)
            {
                //if (AppSettings.EnableHttpProxy &&
                //    AppSettings.CurrentEnvironment.Equals(AppEnvironment.Development))
                //{
                //    var webProxy = new WebProxy(AppSettings.HttpProxyAddress, AppSettings.HttpProxyPort);
                //    httpClient.Proxy = webProxy;
                //}
            }
        }

        private void ConfigureSerializationSettings(IRestClient httpClient)
        {
            if (httpClient is not null)
            {
                httpClient.UseNewtonsoftJson(GenerateJsonSerializerConfigurations());
            }
        }

        public JsonSerializerSettings GenerateJsonSerializerConfigurations()
        {
            return new JsonSerializerSettings
            {
              //  ContractResolver = BuildObjectsAndJsonContractMappings(),
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        private FluentContractResolver BuildObjectsAndJsonContractMappings()
        {
            var jsonContractResolver = new FluentContractResolver();
            jsonContractResolver
                .AddConfiguration(new PetrolPriceDTOMap());
            jsonContractResolver.AddConfiguration(new PetrolResponseContentDTOMap());
            return jsonContractResolver;
        }

    }
}
