using indice.Edi;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiFact
{
    class EdiFact
    {
        public static IEdiGrammar grammar = EdiGrammar.NewEdiFact();

        /// <summary>
        /// Deserialize a file into a given EdiFactDocument class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string filename)
        {
            using (var stream = new StreamReader(filename))
            {
                return new EdiSerializer().Deserialize<T>(stream, grammar);
            }
        }

        /// <summary>
        /// Serialize an EdiFactDocument and write to a local file
        /// </summary>
        /// <param name="document"></param>
        /// <param name="filename"></param>
        public static void Serialize(EdiFactDocument document, string filename)
        {
            document.AddTrailers();

            // (Re)set the Trailer segment count just before serializing so it is always correct.
            document.SetSegmentsCount();

            using (var textWriter = new StreamWriter(File.Open(filename, FileMode.Create)))
            {
                using (var ediWriter = new EdiTextWriter(textWriter, grammar))
                {
                    new EdiSerializer().Serialize(ediWriter, document);
                }
            }
        }
    }
}
