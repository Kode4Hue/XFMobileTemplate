using DryIoc;
using MediatR;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using XfMobileTemplate.Presn.Features.Petrol.PetrolPriceSearch;

namespace XfMobileTemplate.Presn.Features.Common
{
    public static class TypeRegistry
    {

        public static void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.AddApplication();
            RegisterForNavigation(containerRegistry);
            RegisterMediator(containerRegistry);
        }

        private static void RegisterForNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<PetrolPriceSearchPage, PetrolPriceSearchPageVM>();
        }

        private static void RegisterMediator(IContainerRegistry containerRegistry)
        {
            var container = containerRegistry.GetContainer();
            container.RegisterDelegate<ServiceFactory>(r => r.Resolve);
            container.RegisterMany(new[] { typeof(IMediator).GetAssembly() },
                //typeof(GetProductCategoriesQuery).GetAssembly(),
                //typeof(GetProductSearchResultQuery).GetAssembly(),
                //typeof(GetCartQuery).GetAssembly()},
                Registrator.Interfaces);
        }
    }
}
