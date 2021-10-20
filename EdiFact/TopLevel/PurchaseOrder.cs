using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    public class PurchaseOrder : EdiFactDocument
    {
        [EdiCondition("4", Path = "DTM/0/0")]
        public DTM OrderDate { get; set; }

        [EdiCondition("63", Path = "DTM/0/0")]
        public DTM DeliveryLatestDate { get; set; }

        [EdiCondition("64", Path = "DTM/0/0")]
        public DTM DeliveryEarliestDate { get; set; }

        [EdiCondition("DEL", Path = "FTX/0/0")]
        public FTX DeliveryInformation { get; set; }

        [EdiCondition("DP", Path = "NAD/0")]
        public NAD DeliveryParty { get; set; }

        [EdiCondition("BY", Path = "NAD/0")]
        public NAD Buyer { get; set; }

        [EdiCondition("SU", Path = "NAD/0")]
        public NAD Supplier { get; set; }

        public List<LIN> Lines { get; set; }
    }
}