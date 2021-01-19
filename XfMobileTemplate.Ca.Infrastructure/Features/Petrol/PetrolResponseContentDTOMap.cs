using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using XfMobileTemplate.Ca.Domain.Features.Common;
using XfMobileTemplate.Ca.Domain.Features.Petrol;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Petrol
{
    public class PetrolResponseContentDTOMap : IJsonTypeConfiguration<ResponseContentDTO<PetrolPriceDTO>>
    {
        public void Configure(JsonTypeBuilder<ResponseContentDTO<PetrolPriceDTO>> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.HelpText)
                .HasFieldName("help");

            jsonTypeBuilder.Property(x => x.IsSuccess)
                .HasFieldName("success");

            jsonTypeBuilder.Property(x => x.Result)
                .HasFieldName("result");
        }
    }
}
