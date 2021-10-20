using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Free Text", Mandatory = true), EdiPath("FTX")]
    public class FTX
    { 
        [EdiValue("X(3)", Path = "FTX/0/0")]
        public string Type { get; set; }

        [EdiValue("X(3)", Path = "FTX/1/1")]
        public string TextFunction { get; set; }

        [EdiValue("X(3)", Path = "FTX/2/0")]
        public string TextReference { get; set; }

        [EdiValue("X(70)", Path = "FTX/3/0")]
        public string FreeText1 { get; set; }

        [EdiValue("X(70)", Path = "FTX/3/1")]
        public string FreeText2 { get; set; }

        [EdiValue("X(70)", Path = "FTX/3/2")]
        public string FreeText3 { get; set; }

        [EdiValue("X(70)", Path = "FTX/3/3")]
        public string FreeText4 { get; set; }

        [EdiValue("X(70)", Path = "FTX/3/4")]
        public string FreeText5 { get; set; }

        [EdiValue("X(3)", Path = "FTX/3/5")]
        public string Language { get; set; }

        
    }
}