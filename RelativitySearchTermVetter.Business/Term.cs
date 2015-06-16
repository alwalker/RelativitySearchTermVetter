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
        private string _rawText;
        private string _correctedText;

        public String LineNumber { get { return _lineNumber.ToString(); } }
        public String RawText { get { return _rawText; } }
        public String Comment { get; set;}

        public Term(int lineNumber, String raw)
        {
            _lineNumber = lineNumber;
            _rawText = raw;
        }
    }
}
