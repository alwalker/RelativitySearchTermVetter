using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business.Rules
{
    public class MissingWith : Rule
    {
        public override String ViolationDescription { get { return "Missing 'w' on proximity search"; } }

        public override bool Validate(Term term)
        {
            var result = false;

            if (String.IsNullOrEmpty(term.RawText))
            {
                result = true;
            }
            else if (!Regex.Match(term.RawText, @".*\s\/.+").Success)
            {
                result = true;
            }

            return result;
        }
    }
}
