using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Quantity", Mandatory = true), EdiPath("QTY")]
    public class QTY
    {
        [EdiValue(/*"X(3)",*/ Path = "QTY/0/0")]
        public QuantityType Type { get; set; }

        [EdiValue("X(15)", Path = "QTY/0/1")]
        public string Quantity { get; set; }

        public static QTY Instance(QuantityType type, string quantity)
        {
            return new QTY()
            {
                Type = type,
                Quantity = quantity,
            };
        }
    }
}