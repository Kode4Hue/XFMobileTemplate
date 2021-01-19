using System;

namespace XfMobileTemplate.Ca.Domain.Features.Petrol
{
    public class PetrolPriceDTO
    {
        public string ItemId { get; set; }
        public string OutletId { get; set; }
        public string SurveyDate { get; set; }
        public string OutletName { get; set; }
        public string Town { get; set; }
        public string Parish { get; set; }
        public string Item { get; set; }
        public string Price { get; set; }

        public string Id
        {
            get { return ItemId; }
            set { ItemId = value; }
        }

        public string Name
        {
            get { return Item; }
            set { Item = value; }
        }
    }
}
