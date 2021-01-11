using Prism;
using Prism.Ioc;
using System;
using XfMobileTemplate.Presn.Features.Common;
using XfMobileTemplate.Presn.Features.Common.Constants;

namespace XfMobileTemplate
{
    public partial class App
    {

        public App() : this(null)
        {
        }

        public App(IPlatformInitializer initializer) : base(initializer)
        {

        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            try
            {
                var result = await NavigationService
                    .NavigateAsync($"{NavigationPageConstants.NavigationPage}" +
                    $"/{NavigationPageConstants.PetrolPriceSearchPage}");
            }
            catch (Exception ex)
            { 
                throw ex;
            }

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            TypeRegistry.RegisterTypes(containerRegistry);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
