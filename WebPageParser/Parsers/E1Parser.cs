using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPageParser.Interfaces;

namespace WebPageParser.Parsers
{
    public class E1Parser : IWebPageParser
    {
        public string CVsUrl { get; set; }

        public E1Parser(string Url)
        {
            CVsUrl = Url;
        }

    }
}
