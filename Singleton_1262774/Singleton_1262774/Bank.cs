using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_1262774
{
    internal class Bank
    {
        public double GetCurrentCheckingBalance(int accountNum)
        {
            // Simulated value for checking balance
            return 50000;
        }

        public double GetSavingBalance(int accountNum)
        {
            // Simulated value for savings balance
            return 30000;
        }
    }
}
