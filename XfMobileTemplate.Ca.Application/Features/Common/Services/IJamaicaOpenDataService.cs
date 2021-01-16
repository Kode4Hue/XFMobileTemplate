using System.Threading.Tasks;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;

namespace XfMobileTemplate.Ca.Application.Features.Common.Services
{
    public interface IJamaicaOpenDataService
    {
        Task<ResultDTO<PetrolPriceDTO>> GetPetrolPrices(int limit);
    }
}
