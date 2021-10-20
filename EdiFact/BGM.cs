using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Message Begin", Mandatory = true), EdiPath("BGM")]
    public class BGM
    { 
        [EdiValue(/*"X(3)",*/ Path = "BGM/0/0")]
        public DocumentType Type { get; set; }

        [EdiValue("X(3)", Path = "BGM/0/1")]
        public string CodeListQualifier { get; set; }

        [EdiValue("X(3)", Path = "BGM/0/2")]
        public string CodeListAgency { get; set; }

        [EdiValue("X(35)", Path = "BGM/0/3")]
        public string MessageName { get; set; }

        [EdiValue("X(20)", Path = "BGM/1/0")]
        public string InvoiceNumber { get; set; }

        [EdiValue(/*"X(3)",*/ Path = "BGM/2/0")]
        public MessageFunction MessageFunction { get; set; }
    }
}