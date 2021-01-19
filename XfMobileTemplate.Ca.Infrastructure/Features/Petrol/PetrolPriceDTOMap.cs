using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using XfMobileTemplate.Ca.Domain.Features.Petrol;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Petrol
{
    public class PetrolPriceDTOMap : IJsonTypeConfiguration<PetrolPriceDTO>
    {
        public void Configure(JsonTypeBuilder<PetrolPriceDTO> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.Item)
               .HasFieldName("Item");
            jsonTypeBuilder.Property(x => x.ItemId)
              .HasFieldName("ItemID");
            jsonTypeBuilder.Property(x => x.OutletId)
                .HasFieldName("OutletID");
            jsonTypeBuilder.Property(x => x.OutletName)
                .HasFieldName("Outlet_Name");

            jsonTypeBuilder.Property(x => x.Id)
                .IsIgnored(true);

            jsonTypeBuilder.Property(x => x.Name)
                .IsIgnored(true);
        }
    }
}
