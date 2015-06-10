using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business
{
    public class FileTermLoader : TermLoader
    {
        public override void Load(IList<Term> terms, string source)
        {
            if (terms == null)
            {
                throw new ArgumentException("source can not be null or empty!");
            }
            if (!File.Exists(source))
            {
                throw new ArgumentException("source points to non existing file!");
            }

            using (var fs = File.Open(source, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var bs = new BufferedStream(fs))
            using (var sr = new StreamReader(bs))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        terms.Add(new Term(line.Trim()));
                    }
                }
            }
        }
    }
}
