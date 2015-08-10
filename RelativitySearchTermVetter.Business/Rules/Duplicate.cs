using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business.Rules
{
   public class Duplicate : Rule
    {
        public override string GetViolationDescription(params String[] args)
        {
            if (args.Length >= 1)
            {
                return String.Format("Duplicate of line {0}", args[0]);
            }
            else
            {
                return "Duplicate";
            }
        }

        public override bool Validate(Term term)
        {
            throw new NotImplementedException();
        }
    }
}
