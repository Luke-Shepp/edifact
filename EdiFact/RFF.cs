using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Reference"), EdiPath("RFF")]
    public class RFF
    {
        [EdiValue("X(50)", Path = "RFF/0/0")]
        public string ReferenceQualifier { get; set; }

        [EdiValue("X(50)", Path = "RFF/0/1")]
        public string ReferenceNumber { get; set; }

        public static RFF Instance(string qualifier, string reference)
        {
            return new RFF()
            {
                ReferenceNumber = reference,
                ReferenceQualifier = qualifier,
            };
        }
    }
}