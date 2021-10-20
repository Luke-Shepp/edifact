using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Section control", Mandatory = true), EdiPath("UNS")]
    public class UNS
    {
        [EdiValue("X(1)"), EdiPath("UNS/0/0")]
        public string SectionIdentification { get; set; }

        public static UNS Instance(string sectionIdentification)
        {
            return new UNS()
            {
                SectionIdentification = sectionIdentification,
            };
        }
    }
}