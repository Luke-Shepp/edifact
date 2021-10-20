using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(), EdiPath("LOC")]
    public class LOC
    {
        [EdiValue("X(3)", Path = "LOC/0/0")]
        public Place Place { get; set; }
    }
}