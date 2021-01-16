using MediatR;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XfMobileTemplate.Ca.Application.Features.Petrol.Queries.GetPetrolPricesQuery;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;
using XfMobileTemplate.Presn.Features.Common.ViewModels;

namespace XfMobileTemplate.Presn.Features.Petrol.PetrolPriceSearch
{
    public class PetrolPriceSearchPageVM: MediatRViewModelBase, IInitializeAsync
    {
        private ObservableCollection<PetrolPriceDTO> _petrolPrices;
        public ObservableCollection<PetrolPriceDTO> PetrolPrices
        {
            get { return _petrolPrices; }
            set { SetProperty(ref _petrolPrices, value); }
        }

        private int _limit;
        //private int _totalRecords;

        public PetrolPriceSearchPageVM(INavigationService navigationService, IMediator mediator)
            :base(navigationService, mediator)
        {
            _limit = 10; //TODO: pull limit from app setting
        }

        public async Task InitializeAsync(INavigationParameters parameters)
        {
            await GetPetrolPrices();
        }

        private async Task GetPetrolPrices()
        {
            var query = new GetPetrolPricesQuery{ Limit = _limit};
            ResultDTO<PetrolPriceDTO> petrolPricesResult = await Mediator.Send(query);
            PetrolPrices = new ObservableCollection<PetrolPriceDTO>(petrolPricesResult.Records);
            // _totalRecords = petrolPricesResult.Total;
        }
    }
}
