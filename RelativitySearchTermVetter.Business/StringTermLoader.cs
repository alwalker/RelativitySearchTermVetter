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
                throw new ArgumentException("terms can not be null!");
            }

            foreach (var rawTerm in source.Split('\n'))
            {
                if (!String.IsNullOrEmpty(rawTerm))
                {
                    terms.Add(new Term(rawTerm.Trim()));
                }
            }
        }
    }
}
