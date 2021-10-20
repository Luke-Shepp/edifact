using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Package Identification", Mandatory = true), EdiPath("PCI")]
    public class PCI
    {
        [EdiValue(/*"X(3)",*/ Path = "PCI/0/0")]
        public MarkingInstructions MarkingInstructions { get; set; }

        [EdiValue("X(35)", Path = "PCI/1/0")]
        public string ShippingInstructions { get; set; }
    }
}