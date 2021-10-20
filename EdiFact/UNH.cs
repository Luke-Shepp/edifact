using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Message Header", Mandatory = true), EdiPath("UNH")]
    public class UNH
    {
        [EdiValue("X(14)", Path = "UNH/0/0")]
        public string MessageRef { get; set; }

        [EdiValue("X(6)", Path = "UNH/1/0")]
        public string MessageType { get; set; }

        [EdiValue("X(3)", Path = "UNH/1/1")]
        public string MessageTypeVersion { get; set; }

        [EdiValue("X(3)", Path = "UNH/1/2")]
        public string MessageTypeRelease { get; set; }

        [EdiValue("X(2)", Path = "UNH/1/3")]
        public string ControllingAgency { get; set; }

        [EdiValue("X(6)", Path = "UNH/1/4")]
        public string AssociationCode { get; set; }
    }
}