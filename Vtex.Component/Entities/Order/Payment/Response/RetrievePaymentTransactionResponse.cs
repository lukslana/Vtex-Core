using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Payment.Response
{
    internal class RetrievePaymentTransactionResponse
    {
        public string status { get; set; }
        public bool isActive { get; set; }
        public string transactionId { get; set; }
        public string merchantName { get; set; }
        public Payment[] payments { get; set; }
        public class Payment
        {
            public string id { get; set; }
            public string paymentSystem { get; set; }
            public string paymentSystemName { get; set; }
            public int value { get; set; }
            public int installments { get; set; }
            public int referenceValue { get; set; }
            public string cardHolder { get; set; }
            public string cardNumber { get; set; }
            public string firstDigits { get; set; }
            public string lastDigits { get; set; }
            public string url { get; set; }
            public string giftCardId { get; set; }
            public string giftCardName { get; set; }
            public string cvv2 { get; set; }
            public string expireMonth { get; set; }
            public string expireYear { get; set; }
            public string giftCardCaption { get; set; }
            public string redemptionCode { get; set; }
            public string group { get; set; }
            public string tid { get; set; }
            public string dueDate { get; set; }
            public Connectorresponses connectorResponses { get; set; }
        }

        public class Connectorresponses
        {
            public string Tid { get; set; }
            public string ReturnCode { get; set; }
            public string Message { get; set; }
            public string authId { get; set; }
        }
    }
}
