using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Additional Product ID", Mandatory = true), EdiPath("PIA")]
    public class PIA
    {
        [EdiValue("X(3)"), EdiPath("PIA/0/0")]
        public ProductIdType Type { get; set; }

        [EdiValue("X(35)"), EdiPath("PIA/1/0")]
        public string ItemNumber { get; set; }

        [EdiValue("X(3)"), EdiPath("PIA/1/1")]
        public string ItemNumberType { get; set; }

        [EdiValue("X(3)"), EdiPath("PIA/1/2")]
        public string CodeListQualifier { get; set; }

        [EdiValue("X(3)"), EdiPath("PIA/1/3")]
        public string CodeListAgency { get; set; }
    }
}