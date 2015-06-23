using RelativitySearchTermVetter.Business.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativitySearchTermVetter.Business
{
    public class Term
    {
        private int _lineNumber;
        private String _rawText;
        private String _correctedText;
        private List<Rule> _violatedRules;

        public String LineNumber { get { return _lineNumber.ToString(); } }
        public String RawText { get { return _rawText; } }
        public String Comment { get; set; }
        public List<Rule> ViolatedRules { get { return _violatedRules; } }
        public IEnumerable<String> ViolatedRulesDescriptions { get { return _violatedRules.Select(r => r.ViolationDescription); } }

        public Term(int lineNumber, String raw)
        {
            _lineNumber = lineNumber;
            _rawText = raw;
        }
    }
}
