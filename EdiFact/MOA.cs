using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Monetary Amount"), EdiPath("MOA")]
    public class MOA
    {
        [EdiValue(/*"X(3)",*/ Path = "MOA/0/0")]
        public MonetaryAmountType Type { get; set; }

        [EdiValue("X(18)", Path = "MOA/0/1")]
        public string Amount { get; set; }

        [EdiValue("X(3)", Path = "MOA/0/2")]
        public string Currency { get; set; }

        [EdiValue("X(3)", Path = "MOA/0/3")]
        public string CurrencyQualifier { get; set; }

        [EdiValue("X(3)", Path = "MOA/0/4")]
        public string Status { get; set; }

        public static MOA Instance(MonetaryAmountType type, double amount, string currency = "GBP")
        {
            return new MOA()
            {
                Type = type,
                Amount = amount.ToString(),
                Currency = currency,
            };
        }
    }
}