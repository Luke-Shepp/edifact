using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace EdiFact
{
    [EdiSegment(Description = "Date and Time"), EdiPath("DTM")]
    public class DTM
    {
        [EdiValue(/*"X(3)",*/ Path = "DTM/0/0")]
        public DateType Qualifier { get; set; }

        [EdiValue("X(35)", Path = "DTM/0/1")]
        public string Period { get; set; }

        [EdiValue(/*"X(3)",*/ Path = "DTM/0/2")]
        public DateFormat FormatQualifier { get; set; }

        public static DTM Instance(DateType qualifier, string period, DateFormat formatQualifier = DateFormat.YYYYMMDD)
        {
            return new DTM()
            {
                Qualifier = qualifier,
                Period = period,
                FormatQualifier = formatQualifier,
            };
        }

        public static DTM FromDateTime(DateType qualifier, DateTime dateTime, DateFormat formatQualifier = DateFormat.YYYYMMDD)
        {
            string formatted;

            switch (formatQualifier)
            {
                case DateFormat.YYYYMMDD:
                    formatted = dateTime.ToString("yyyyMMdd");
                    break;
                case DateFormat.CCYYMMDDHHMM:
                    formatted = dateTime.ToString("yyyyMMddHHmm");
                    break;
                default:
                    throw new NotImplementedException($"DTM.FromDateTime with format {formatQualifier} not implemented.");
            }

            return new DTM()
            {
                Qualifier = qualifier,
                FormatQualifier = formatQualifier,
                Period = formatted,
            };
        }

        public DateTime? ToDateTime()
        {
            DateTime parsed;

            switch (FormatQualifier)
            {
                case DateFormat.YYYYMMDD:
                    if (DateTime.TryParseExact(Period, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsed))
                    {
                        return parsed;
                    }
                    break;
                default:
                    throw new NotImplementedException($"DTM.ToDateTime with format {FormatQualifier} not implemented.");
            }

            return null;
        }
    }
}