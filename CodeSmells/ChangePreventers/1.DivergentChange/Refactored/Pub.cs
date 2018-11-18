using System;
using System.Collections.Generic;

namespace CodeSmells.ChangePreventers._1.DivergentChange.Refactored
{
    public class Pub
    {
    public static String ONE_BEER = "hansa";
    public static String ONE_CIDER = "grans";
    public static String A_PROPER_CIDER = "strongbow";
    public static String GT = "gt";
    public static String BACARDI_SPECIAL = "bacardi_special";
    public static int STUDENT_DISCOUNT = 10;
    public static int MAX_NUMBER_OF_DRINKS = 2;
    private IDictionary<String, IBeverage> menu;

        public Pub()
        {
            menu = new Dictionary<String, IBeverage>();
            menu.Add(ONE_BEER, new SimpleBeverage(74));
            menu.Add(ONE_CIDER, new SimpleBeverage(103));
            menu.Add(A_PROPER_CIDER, new SimpleBeverage(110));
            menu.Add(GT, new Cocktail()
                                .withIngredient(IngredientUnit.GIN)
                                .withIngredient(IngredientUnit.TONIC_WATER)
                                .withIngredient(IngredientUnit.GREEN_STUFF));
            menu.Add(BACARDI_SPECIAL, new Cocktail()
                                .withIngredient(IngredientUnit.GIN, 0.5)
                                .withIngredient(IngredientUnit.RUM)
                                .withIngredient(IngredientUnit.GRENADINE)
                                .withIngredient(IngredientUnit.LIME_JUICE));
        }

        public int ComputeCost(String drink, bool student, int amount)
        {

            if (!menu.ContainsKey(drink))
            {
                throw new Exception("No such drink exists");
            }

            IBeverage beverage = menu[drink];

            if (amount > MAX_NUMBER_OF_DRINKS && beverage.isAmountLimited())
            {
                throw new Exception("Too many drinks, max " + MAX_NUMBER_OF_DRINKS);
            }

            int price = beverage.GetPrice();

            if (student && beverage.isEligableForStudentDiscount())
            {
                price = price - price / STUDENT_DISCOUNT;
            }

            return price * amount;
        }
    }
}
