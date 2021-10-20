using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Name and Address", Mandatory = true), EdiPath("NAD")]
    public class NAD
    {
        [EdiValue("X(3)", Path = "NAD/0/0")]
        public string Qualifier { get; set; } // BY / SU / ST

        [EdiValue("X(35)", Path = "NAD/1/0")]
        public string PartyId { get; set; }

        [EdiValue(/*"X(3)",*/ Path = "NAD/1/2")]
        public IdentifierType Agency { get; set; }

        [EdiValue("X(35)", Path = "NAD/2/0")]
        public string Line1 { get; set; }

        [EdiValue("X(35)", Path = "NAD/2/1")]
        public string Line2 { get; set; }

        [EdiValue("X(35)", Path = "NAD/2/2")]
        public string Line3 { get; set; }

        [EdiValue("X(35)", Path = "NAD/2/3")]
        public string Line4 { get; set; }

        [EdiValue("X(35)", Path = "NAD/2/4")]
        public string Line5 { get; set; }

        [EdiValue("X(35)", Path = "NAD/3/0")]
        public string PartyName { get; set; }
        
        [EdiValue("X(35)", Path = "NAD/4/0")]
        public string Street { get; set; }
        
        [EdiValue("X(35)", Path = "NAD/5/0")]
        public string City { get; set; }

        [EdiValue("X(35)", Path = "NAD/6/0")]
        public string Country { get; set; }

        [EdiValue("X(35)", Path = "NAD/7/0")]
        public string PostCode { get; set; }

        [EdiValue("X(35)", Path = "NAD/8/0")]
        public string CountryCode { get; set; }

    }
}