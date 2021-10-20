using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Transmission Control", Mandatory = true), EdiPath("UNB")]
    public class UNB
    {
        [EdiValue("X(4)", Path = "UNB/0/0")]
        public string SyntaxIdentifier { get; set; }

        [EdiValue("X(1)", Path = "UNB/0/1")]
        public string SyntaxVersion { get; set; }

        [EdiValue("9(14)", Path = "UNB/1/0")]
        public string SenderId { get; set; }

        [EdiValue(/*"X(4)",*/ Path = "UNB/1/1")]
        public IdentifierType SenderIdQualifier { get; set; }

        [EdiValue("9(14)", Path = "UNB/2/0")]
        public string RecipientId { get; set; }

        [EdiValue(/*"X(4)",*/ Path = "UNB/2/1")]
        public IdentifierType RecipientIdQualifier { get; set; }

        [EdiValue(Path = "UNB/3/0")]
        public string DateOfPreparation { get; set; }

        [EdiValue(Path = "UNB/3/1")]
        public string TimeOfPreparation { get; set; }

        [EdiValue(Path = "UNB/4/0")]
        public string ControlRef { get; set; }
    }
}