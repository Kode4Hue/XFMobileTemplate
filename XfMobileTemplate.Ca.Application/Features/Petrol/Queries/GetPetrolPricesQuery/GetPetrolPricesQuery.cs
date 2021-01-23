using MediatR;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;

namespace XfMobileTemplate.Ca.Application.Features.Petrol.Queries.GetPetrolPricesQuery
{
    public class GetPetrolPricesQuery: IRequest<ResultDTO<PetrolPriceDTO>>
    {
        public int Limit { get; set; }
    }
}
