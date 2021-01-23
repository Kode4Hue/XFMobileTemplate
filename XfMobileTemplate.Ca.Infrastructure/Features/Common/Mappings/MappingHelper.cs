using Newtonsoft.FluentAPI.Resolvers;
using Newtonsoft.Json;
using XfMobileTemplate.Ca.Infrastructure.Features.Petrol;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Mappings
{
    public static class MappingHelper
    {
        public static void ConfigureHttpJsonSerializerSettings()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = BuildObjectsAndJsonContractMappings(),
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        private static FluentContractResolver BuildObjectsAndJsonContractMappings()
        {
            var jsonContractResolver = new FluentContractResolver();
            jsonContractResolver
                .AddConfiguration(new PetrolPriceDTOMap());
            jsonContractResolver.AddConfiguration(new PetrolResponseContentDTOMap());
            return jsonContractResolver;
        }
    }
}
