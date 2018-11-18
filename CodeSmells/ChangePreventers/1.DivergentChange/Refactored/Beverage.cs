using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells.ChangePreventers._1.DivergentChange.Refactored
{
    public interface IBeverage
    {
        int GetPrice();
        bool isAmountLimited();
        bool isEligableForStudentDiscount();
    }


   
}
