using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Interchange Trailer", Mandatory = true), EdiPath("UNZ")]
    public class UNZ
    {
        [EdiValue("9(6)"), EdiPath("UNZ/0")]
        public int MessageCount { get; set; }

        [EdiValue("X(14)"), EdiPath("UNZ/1")]
        public string ControlReference { get; set; }
    }
}