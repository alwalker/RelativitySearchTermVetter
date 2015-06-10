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
        private string _comment;

        public Term(string raw)
        {
            _rawText = raw;
        }
    }
}
