using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    class ASN : EdiFactDocument
    {
        [EdiCondition("67", Path = "DTM/0/0")]
        public DTM DeliveryDate { get; set; }

        [EdiCondition("AAU", Path = "RFF/0/0")]
        public RFF DespatchNoteAdvice { get; set; }

        [EdiCondition("ON", Path = "RFF/0/0")]
        public RFF OrderNumber { get; set; }

        [EdiCondition("BN", Path = "RFF/0/0")]
        public RFF BookingNumber { get; set; }

        [EdiCondition("SU", Path = "NAD/0")]
        public NAD Supplier { get; set; }

        [EdiCondition("ST", Path = "NAD/0")]
        public NAD ShipTo { get; set; }

        public List<CPS> Packs { get; set; }
    }
}