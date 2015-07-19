using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business.Rules
{
    public abstract class Rule
    {
        public abstract String ViolationDescription { get; }

        public abstract bool Validate(Term term);

        public static IList<Rule> GetAllRules()
        {
            var rules = new List<Rule> 
            {
                new WrongNumberParens(),
                new WrongNumberQuotes(),
                new StarInQuotes(),
                new MissingWith()
            };

            return rules;
        }
    }
}
