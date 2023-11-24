using System;
namespace Vtex.Component.Entities.GiftCard.GiftCard.Response
{
    public class GetGiftCardbyIDResponse: BaseGiftCardResponse
    {
        public string id { get; set; }
        public string redemptionToken { get; set; }
        public string redemptionCode { get; set; }
        public float balance { get; set; }
        public string relationName { get; set; }
        public DateTime emissionDate { get; set; }
        public DateTime expiringDate { get; set; }
        public string caption { get; set; }
        public string provider { get; set; }
        public Transaction transaction { get; set; }
   
        public class Transaction
        {
            public string href { get; set; }
        }
    
    }
}
