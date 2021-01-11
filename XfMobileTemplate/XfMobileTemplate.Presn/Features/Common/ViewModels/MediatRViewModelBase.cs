using MediatR;
using Prism.Navigation;

namespace XfMobileTemplate.Presn.Features.Common.ViewModels
{
    public abstract class MediatRViewModelBase: ViewModelBase
    {
        protected readonly IMediator Mediator;

        public MediatRViewModelBase(INavigationService navigationService, IMediator mediator) : base(navigationService)
        {
            Mediator = mediator;
        }
    }
}
