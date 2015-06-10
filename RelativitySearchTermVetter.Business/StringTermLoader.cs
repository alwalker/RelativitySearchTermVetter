using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business
{
    public class StringTermLoader : TermLoader
    {
        public override void Load(IList<Term> terms, String source)
        {
            if (terms == null)
            {
                throw new ArgumentException("source can not be null or empty!");
            }

            var lineNumber = 1;
            foreach (var rawTerm in source.Split('\n'))
            {
                if (!String.IsNullOrEmpty(rawTerm.Trim()))
                {
                    terms.Add(new Term(lineNumber, rawTerm.Trim()));
                    lineNumber++;
                }
            }
        }
    }
}
