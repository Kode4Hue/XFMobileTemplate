using MediatR;
using Prism.Events;
using Prism.Navigation;

namespace XfMobileTemplate.Presn.Features.Common.ViewModels
{
    public class EventViewModelBase: MediatRViewModelBase
    {
        protected IEventAggregator EventAggregator;

        public EventViewModelBase(INavigationService navigationService, IMediator mediator, IEventAggregator eventAggregator) : base(navigationService, mediator)
        {
            EventAggregator = eventAggregator;
        }

    }
}
