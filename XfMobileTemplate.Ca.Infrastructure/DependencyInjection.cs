using Prism.Ioc;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;
using XfMobileTemplate.Ca.Application.Features.Common.Services;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Factories;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Services;

namespace XfMobileTemplate.Ca.Infrastructure
{
    public static class DependencyInjection
    {

        public static IContainerRegistry AddInfrastructure(this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ICustomHttpClientFactory, CustomHttpClientFactory>();
            containerRegistry.Register<IJamaicaOpenDataService, JamaicaOpenDataService>();

            return containerRegistry;
        }
    }
}
