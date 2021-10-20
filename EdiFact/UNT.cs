using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Message Trailer", Mandatory = true), EdiPath("UNT")]
    public class UNT
    {
        [EdiValue("9(6)"), EdiPath("UNT/0")]
        public int SegmentCount { get; set; }

        [EdiValue("X(14)"), EdiPath("UNT/1")]
        public string MessageReference { get; set; }
    }
}