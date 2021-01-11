using MediatR;
using Prism.Navigation;
using XfMobileTemplate.Presn.Features.Common.ViewModels;

namespace XfMobileTemplate.Presn.Features.Petrol.PetrolPriceSearch
{
    public class PetrolPriceSearchPageVM: MediatRViewModelBase
    {
        public PetrolPriceSearchPageVM(INavigationService navigationService, IMediator mediator)
            :base(navigationService, mediator)
        {
        }
    }
}
