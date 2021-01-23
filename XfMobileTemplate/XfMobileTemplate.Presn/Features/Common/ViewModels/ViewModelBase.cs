using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XfMobileTemplate.Presn.Features.Common.ViewModels
{
    public abstract class ViewModelBase: BindableBase
    {
        protected INavigationService NavigationService;

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
