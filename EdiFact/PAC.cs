using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Package", Mandatory = true), EdiSegmentGroup("PAC")]
    public class PAC
    {
        [EdiValue("X(8)", Path = "PAC/0")]
        public string PackageCount { get; set; }

        [EdiValue("X(3)", Path = "PAC/1/0")]
        public string PackagingLevel { get; set; }

        [EdiValue("X(3)", Path = "PAC/1/1")]
        public string PackagingInformation { get; set; }

        [EdiValue("X(3)", Path = "PAC/1/2")]
        public string PackagingTerms { get; set; }

        [EdiValue("X(17)", Path = "PAC/2/0")]
        public string PackagesTypeIdentification { get; set; }

        [EdiValue("X(3)", Path = "PAC/2/1")]
        public string CodeListQualifier { get; set; }

        [EdiValue("X(3)", Path = "PAC/2/2")]
        public string CodeListAgency { get; set; }

        [EdiValue("X(35)", Path = "PAC/2/3")]
        public string PackagesType { get; set; }

        [EdiValue("X(3)", Path = "PAC/3/0")]
        public string ItemDescriptionType { get; set; }

        [EdiValue("X(35)", Path = "PAC/3/1")]
        public string PackagesType2 { get; set; }

        [EdiValue("X(3)", Path = "PAC/3/2")]
        public string ItemNumberType { get; set; }

        [EdiValue("X(3)", Path = "PAC/4/0")]
        public string ReturnableFreightResponsibility { get; set; }

        [EdiValue("X(3)", Path = "PAC/4/1")]
        public string ReturnablePackageLoadContents { get; set; }

        [EdiCondition("52", "QTY/0/0")]
        public QTY PackItemQuantity { get; set; }

        public PCI Identification { get; set; }

        [EdiCondition("BJ", Path = "GIN/0/0")]
        public GIN SerialContainerCode { get; set; }

        public List<LIN> Lines { get; set; }
    }
}