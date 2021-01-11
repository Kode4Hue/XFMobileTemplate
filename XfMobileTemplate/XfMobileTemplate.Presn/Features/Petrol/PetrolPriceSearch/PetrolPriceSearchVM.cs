using MediatR;
using Prism.Navigation;
using XfMobileTemplate.Presn.Features.Common.ViewModels;

namespace XfMobileTemplate.Presn.Features.Petrol.PetrolPriceSearch
{
    public class PetrolPriceSearchVM: MediatRViewModelBase
    {
        public PetrolPriceSearchVM(INavigationService navigationService, IMediator mediator)
            :base(navigationService, mediator)
        {
        }
    }
}
