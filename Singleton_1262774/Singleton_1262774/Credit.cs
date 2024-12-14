using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_1262774
{
    internal class Credit
    {
        public CreditRating CheckCredit(string ssn)
        {
            // Simulated credit check
            return CreditRating.GOOD;
        }
    }

    internal enum CreditRating
    {
        EXCELLENT,
        GOOD,
        FAIR,
        POOR
    }
}
