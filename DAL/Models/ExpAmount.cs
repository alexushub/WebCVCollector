using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public enum ExpAmount
    {
        WithoutExp = 0,
        Less1 = 1,
        From1To3 = 2,
        From3To5 = 3,
        Over5 = 4
    }

    public static class DALConstants
    {
        public static string[] expAmountDisplay = { "Without expirience", "Less than 1 year", "1-3 years", "3-5 years", "More than 5 years" };
    }
}
