using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    class Invoice : EdiFactDocument
    {
        [EdiCondition("137", Path = "DTM/0/0")]
        public DTM DocumentDate { get; set; }

        [EdiCondition("35", Path = "DTM/0/0")]
        public DTM DeliveryDate { get; set; }

        [EdiCondition("3", Path = "DTM/0/0")]
        public DTM InvoiceDate { get; set; }

        [EdiCondition("265", Path = "DTM/0/0")]
        public DTM DueDate { get; set; }

        [EdiCondition("ON", Path = "RFF/0/0")]
        public RFF OrderNumber { get; set; }

        [EdiCondition("DQ", Path = "RFF/0/0")]
        public RFF DeliveryNoteNumber { get; set; }

        [EdiCondition("BN", Path = "RFF/0/0")]
        public RFF BookingNumber { get; set; }

        [EdiCondition("BY", Path = "NAD/0")]
        public NAD Buyer { get; set; }

        [EdiCondition("SU", Path = "NAD/0")]
        public NAD Supplier { get; set; }

        [EdiCondition("ST", Path = "NAD/0")]
        public NAD ShipTo { get; set; }

        [EdiCondition("VA", Path = "RFF/0/0")]
        public RFF VatCode { get; set; }

        public CUX Currency { get; set; }

        public List<LIN> Lines { get; set; }

        public UNS SectionBreak { get; set; }

        [EdiCondition("77", Path = "MOA/0/0")]
        public MOA InvoiceAmount { get; set; }

        [EdiCondition("86", Path = "MOA/0/0")]
        public MOA MessageTotalAmount { get; set; }

        [EdiCondition("79", Path = "MOA/0/0")]
        public MOA LineItemsAmount { get; set; }

        [EdiCondition("129", Path = "MOA/0/0")]
        public MOA DiscountableAmount { get; set; }

        public TAX Tax { get; set; }

        [EdiCondition("124", Path = "MOA/0/0")]
        public MOA TaxAmount { get; set; }

        [EdiCondition("125", Path = "MOA/0/0")]
        public MOA TaxableAmount { get; set; }
    }
}