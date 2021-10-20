using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Tax Information", Mandatory = true), EdiPath("TAX")]
    public class TAX
    {
        [EdiValue(/*"X(3)",*/ Path = "TAX/0/0")]
        public TaxType Type { get; set; }

        [EdiValue("X(3)", Path = "TAX/1/0")]
        public string TaxType { get; set; }

        [EdiValue("X(17)", Path = "TAX/4/3")]
        public double Rate { get; set; }

        [EdiValue("X(3)", Path = "TAX/5/0")]
        public string RateType { get; set; }
    }
}