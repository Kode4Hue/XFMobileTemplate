using Prism.Ioc;

namespace XfMobileTemplate.Ca.Infrastructure
{
    public static class DependencyInjection
    {

        public static IContainerRegistry AddInfrastructure(this IContainerRegistry containerRegistry)
        {

            return containerRegistry;
        }
    }
}
