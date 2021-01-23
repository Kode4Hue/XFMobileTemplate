using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Petrol
{
    public class PetrolResultDTOMap : IJsonTypeConfiguration<ResultDTO<PetrolPriceDTO>>
    {
        public void Configure(JsonTypeBuilder<ResultDTO<PetrolPriceDTO>> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.ResourceId)
                .HasFieldName("resource_id");

            jsonTypeBuilder.Property(x => x.Limit)
                .HasFieldName("limit");

            jsonTypeBuilder.Property(x => x.Total)
                .HasFieldName("total");

            jsonTypeBuilder.Property(x => x.Records)
                .HasFieldName("records");
        }
    }
}
