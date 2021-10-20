using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Currency", Mandatory = true), EdiPath("CUX")]
    public class CUX
    { 
        [EdiValue(/*"X(3)",*/ Path = "CUX/0/0")]
        public CurrencyDetailType CurrencyDetailType { get; set; }

        [EdiValue("X(35)", Path = "CUX/0/1")]
        public string Currency { get; set; }

        [EdiValue(/*"X(6)",*/ Path = "CUX/0/2")]
        public CurrencyType CurrencyType { get; set; }

        [EdiValue("X(35)", Path = "CUX/0/3")]
        public string CurrencyRateBase { get; set; }
    }
}