using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Item Details", Mandatory = true), EdiPath("IMD")]
    public class IMD
    {
        [EdiValue("X(3)"), EdiPath("IMD/0/0")]
        public string FormatCode { get; set; }

        [EdiValue("X(35)"), EdiPath("IMD/1/0")]
        public string Caracteristic { get; set; }

        [EdiValue("X(3)"), EdiPath("IMD/1/1")]
        public string CodeListQualifier { get; set; }

        [EdiValue("X(3)"), EdiPath("IMD/1/2")]
        public string CodeListAgency { get; set; }

        [EdiValue("X(3)"), EdiPath("IMD/2/0")]
        public string DescriptionCode { get; set; }

        [EdiValue("X(3)"), EdiPath("IMD/2/1")]
        public string CodeListQualifier2 { get; set; }

        [EdiValue("X(3)"), EdiPath("IMD/2/2")]
        public string CodeListAgency2 { get; set; }

        [EdiValue("X(35)"), EdiPath("IMD/2/3")]
        public string Description1 { get; set; }

        [EdiValue("X(35)"), EdiPath("IMD/2/4")]
        public string Description2 { get; set; }

        [EdiValue("X(3)"), EdiPath("IMD/2/5")]
        public string LanguageCode { get; set; }

        [EdiValue("X(3)"), EdiPath("IMD/3/0")]
        public string LayerCode { get; set; }
    }
}