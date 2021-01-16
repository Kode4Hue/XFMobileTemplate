using System;

namespace XfMobileTemplate.Ca.Domain.Features.Petrol
{
    public class PetrolPriceDTO
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string OutletId { get; set; }
        public DateTime SurveyDate { get; set; }
        public string OutletName { get; set; }
        public string Town { get; set; }
        public string Parish { get; set; }
        public string Name { get; set; }

    }
}
