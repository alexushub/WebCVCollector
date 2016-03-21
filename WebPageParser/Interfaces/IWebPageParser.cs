using DAL.Models;
using System;
using System.Collections.Generic;

namespace WebPageParser.Interfaces
{
    public interface IWebPageParser
    {
        string CVsUrl { get; }

        IEnumerable<CV> GetCvs();
    }
}

