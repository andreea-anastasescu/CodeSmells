using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells.ChangePreventers._1.DivergentChange.Refactored
{
    public class Cocktail : IBeverage
    {

    private double price;

   
    public int GetPrice()
    {
        return (int)Math.Floor(price);
    }

    public Cocktail withIngredient(IngredientUnit ingredientUnit)
    {
        return withIngredient(ingredientUnit, 1);
    }

    public Cocktail withIngredient(IngredientUnit ingredientUnit, double amount)
    {
        price += (ingredientUnit.GetPrice() * amount);
        return this;
    }

    public bool isAmountLimited()
    {
        return true;
    }

    
    public bool isEligableForStudentDiscount()
    {
        return false;
    }
  }   

}
