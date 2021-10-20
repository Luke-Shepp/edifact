using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Line Item", Mandatory = true), EdiSegmentGroup("LIN")]
    public class LIN
    {
        [EdiValue("9(6)"), EdiPath("LIN/0")]
        public int LineItemNumber { get; set; }

        [EdiValue("X(3)"), EdiPath("LIN/1")]
        public string Action { get; set; }

        [EdiValue("X(35)"), EdiPath("LIN/2/0")]
        public string ItemNumber { get; set; }

        [EdiValue("X(3)"), EdiPath("LIN/2/1")]
        public string ItemNumberType { get; set; }

        [EdiValue("X(3)"), EdiPath("LIN/2/2")]
        public string CodeListQualifier { get; set; }

        [EdiValue("X(3)"), EdiPath("LIN/2/3")]
        public string CodeListAgency { get; set; }

        [EdiValue("X(3)"), EdiPath("LIN/3")]
        public string SubLineIndicatorCode { get; set; }

        [EdiValue("9(3)"), EdiPath("LIN/4/0")]
        public string ConfigurationLevel { get; set; }

        [EdiValue("X(3)"), EdiPath("LIN/4/1")]
        public string ConfigurationCode { get; set; }
        
        public List<PIA> ProductIds { get; set; }

        public IMD ItemDetails { get; set; }

        [EdiCondition("12", Path = "QTY/0/0")]
        public QTY DispatchQuantity { get; set; }

        [EdiCondition("47", Path = "QTY/0/0")]
        public QTY InvoicedQuantity { get; set; }

        [EdiCondition("21", Path = "QTY/0/0")]
        public QTY OrderedQuantity { get; set; }

        [EdiCondition("146", Path = "MOA/0/0")]
        public MOA UnitAmount { get; set; }

        [EdiCondition("66", Path = "MOA/0/0")]
        public MOA LineAmount { get; set; }

        [EdiCondition("PUR", Path = "FTX/0/0")]
        public FTX PurchasingInformation { get; set; }

        [EdiCondition("AAA", Path = "PRI/0/0")]
        public PRI NetPrice { get; set; }

        [EdiCondition("AAF", Path = "PRI/0/0")]
        public PRI InfoPriceExTax { get; set; }

        [EdiCondition("AAE", Path = "PRI/0/0")]
        public PRI InfoPriceIncTax { get; set; }

        public TAX Tax { get; set; }

        [EdiCondition("124", Path = "MOA/0/0")]
        public MOA TaxAmount { get; set; }

        [EdiCondition("ON", Path = "RFF/0/0")]
        public RFF LineReference { get; set; }

        [EdiCondition("PL", Path = "RFF/0/0")]
        public RFF PriceListNumber { get; set; }

        [EdiCondition("WS", Path = "RFF/0/0")]
        public RFF WarhehouseLocation { get; set; }
    }
}