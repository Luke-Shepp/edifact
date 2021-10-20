using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Prices for items", Mandatory = true), EdiPath("PRI")]
    public class PRI
    {
        [EdiValue("X(3)"), EdiPath("PRI/0/0")]
        public string Qualifier { get; set; }

        [EdiValue("9(15)"), EdiPath("PRI/0/1")]
        public string Price { get; set; }

        [EdiValue("X(3)"), EdiPath("PRI/0/2")]
        public string TypeCoded { get; set; }
    }
}