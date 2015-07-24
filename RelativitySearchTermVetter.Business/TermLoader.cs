using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business
{
    public abstract class TermLoader
    {
        public abstract void Load(IList<Term> terms, String source);

        protected void MarkDupes(IList<Term> terms)
        {

        }
    }
}
