using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Consignment Package Sequence", Mandatory = true), EdiSegmentGroup("CPS")]
    public class CPS
    {
        [EdiValue("X(12)", Path = "CPS/0")]
        public string PackId { get; set; }

        [EdiValue("X(12)", Path = "CPS/1")]
        public string ParentId { get; set; }

        [EdiValue("X(3)", Path = "CPS/2")]
        public string PackagingLevel { get; set; }

        public PAC Package { get; set; }
    }
}