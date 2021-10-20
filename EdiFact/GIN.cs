using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Goods Identity Number", Mandatory = true), EdiPath("GIN")]
    public class GIN
    {
        [EdiValue("X(3)", Path = "GIN/0")]
        public string IdentityNumberQualifier { get; set; }

        [EdiValue("X(20)", Path = "GIN/1")]
        public string IdentityNumber { get; set; }
    }
}