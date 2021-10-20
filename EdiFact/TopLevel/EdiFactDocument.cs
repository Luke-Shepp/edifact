using indice.Edi.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EdiFact
{
    public class EdiFactDocument
    {
        public UNB InterchangeHeader { get; set; }

        public UNH MessageHeader { get; set; }

        public BGM BeginMessage { get; set; }

        public UNT MessageTrailer { get; set; }

        public UNZ InterchangeTrailer { get; set; }

        /// <summary>
        /// Count the number of segments in the given object / document.
        /// 
        /// Message and interchange trailers will be removed from the count if the segments are present.
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public int CountSegments(object document)
        {
            bool IsSegment(MemberInfo type) => Attribute.IsDefined(type, typeof(EdiSegmentAttribute));
            bool IsSegmentGroup(MemberInfo type) => Attribute.IsDefined(type, typeof(EdiSegmentGroupAttribute));

            int segmentCount = 0;

            Type objType = document.GetType();

            foreach (PropertyInfo property in objType.GetProperties())
            {
                object propertyValue = property.GetValue(document);

                if (propertyValue == null)
                {
                    continue; // skip null properties
                }

                Type propertyType = property.PropertyType;

                if (IsSegmentGroup(propertyType))
                {
                    segmentCount = CountSegments(propertyValue) + 1;
                }
                else if (IsSegment(propertyType))
                {
                    segmentCount++;
                }
                else if (propertyType.IsGenericType && typeof(IEnumerable).IsAssignableFrom(propertyType))
                {
                    Type itemType = propertyType.GetGenericArguments()[0];
                    List<object> collection = ((IEnumerable)propertyValue).Cast<object>().ToList();

                    if (IsSegmentGroup(itemType)) // list of segment groups
                    {
                        segmentCount += collection.Sum(CountSegments) + collection.Count;
                    }
                    else if (IsSegment(itemType)) // list of segments
                    {
                        segmentCount += collection.Count;
                    }
                }
            }

            if (MessageTrailer != default(UNT))
            {
                segmentCount--;
            }

            if (InterchangeTrailer != default(UNZ))
            {
                segmentCount--;
            }

            return segmentCount;
        }

        /// <summary>
        /// Add message and interchange trailers to the message with default values, if they are not already
        /// </summary>
        public void AddTrailers()
        {
            if (MessageTrailer == default(UNT))
            {
                MessageTrailer = new UNT()
                {
                    MessageReference = MessageHeader.MessageRef,
                };
            }

            if (InterchangeTrailer == default(UNZ))
            {
                InterchangeTrailer = new UNZ()
                {
                    MessageCount = 1,
                    ControlReference = InterchangeHeader.ControlRef,
                };
            }
        }

        /// <summary>
        /// Sets the message trailer segment count to a newly counted value
        /// </summary>
        public void SetSegmentsCount()
        {
            MessageTrailer.SegmentCount = CountSegments(this);
        }
    }
}
