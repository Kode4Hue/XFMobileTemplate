using MediatR;
using System.Threading;
using System.Threading.Tasks;
using XfMobileTemplate.Ca.Application.Features.Common.Services;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;

namespace XfMobileTemplate.Ca.Application.Features.Petrol.Queries.GetPetrolPricesQuery
{
    public class GetPetrolPricesQueryHandler : IRequestHandler<GetPetrolPricesQuery, ResultDTO<PetrolPriceDTO>>
    {
        private IJamaicaOpenDataService _jamaicaOpenDataService;

        public GetPetrolPricesQueryHandler(IJamaicaOpenDataService jamaicaOpenDataService)
        {
            _jamaicaOpenDataService = jamaicaOpenDataService;
        }

        public async Task<ResultDTO<PetrolPriceDTO>> Handle(GetPetrolPricesQuery request, CancellationToken cancellationToken)
        {
            return await _jamaicaOpenDataService.GetPetrolPrices(request.Limit);
        }
    }
}
