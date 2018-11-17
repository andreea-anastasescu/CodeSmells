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


    public class SimpleBeverage: IBeverage
    {
    private int  price;
    private bool isEligibleForStudentDiscount;
    private bool isAmmountlimited;

    public SimpleBeverage(int price, bool isAmmountLimited = false, bool isEligibleForStudentDiscount = true)
    {
        this.price = price;
    }

    public int GetPrice()
    {
        return price;
    }

    
    public bool isAmountLimited()
    {
        return false;
    }

    public bool isEligableForStudentDiscount()
    {
        return true;
    }
}
}
