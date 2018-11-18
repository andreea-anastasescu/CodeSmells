using System;
using System.Collections.Generic;

namespace CodeSmells.ChangePreventers._1.DivergentChange.Refactored
{

    public enum IngredientUnit
    {
        GIN,
        TONIC_WATER,
        GREEN_STUFF,
        RUM,
        GRENADINE,
        LIME_JUICE
    }


    public static class IngredientUnitPriceList
    {

        private static readonly IDictionary<IngredientUnit, int> ingredientPriceList = new Dictionary<IngredientUnit, int>
        {
            { IngredientUnit.GIN, 85},
            { IngredientUnit.TONIC_WATER, 20 },
            { IngredientUnit.GREEN_STUFF, 10 },
            { IngredientUnit.RUM,65 },
            { IngredientUnit.GRENADINE,10 },
            { IngredientUnit.LIME_JUICE,10 }

    };

        public static  int GetPrice(this IngredientUnit ingredient) {
            if (!(ingredientPriceList.Keys.Contains(ingredient)))
             {
                throw new Exception("Ingredient Not Found!");
            }

            return ingredientPriceList[ingredient];

        }

    }
    
}
