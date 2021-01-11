using MediatR;
using Prism.Ioc;
using XfMobileTemplate.Ca.Application.Features.Common.Behaviours;

namespace XfMobileTemplate.Ca.Application
{
    public static class DependencyInjection
    {
        public static IContainerRegistry AddApplication(this IContainerRegistry containerRegistry)
        {
            RegisterApplicationTypes(containerRegistry);
            return containerRegistry;
        }
        private static void RegisterApplicationTypes(IContainerRegistry containerRegistry)
        {
            // containerRegistry.Register(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            containerRegistry.Register(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            containerRegistry.Register(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        }
    }
}
