﻿using System;
using System.Collections.Generic;

namespace CodeSmells.ChangePreventers._1.DivergentChange.Refactored
{
    public class Pub
    {
    public static  String ONE_BEER = "hansa";
    public static  String ONE_CIDER = "grans";
    public static  String A_PROPER_CIDER = "strongbow";
    public static  String GT = "gt";
    public static  String BACARDI_SPECIAL = "bacardi_special";


     
    private static IDictionary<string, IBeverage> menu = new Dictionary<string, IBeverage>(); 



    public int computeCost(String drink, bool student, int amount)
        {
            if (IsLimitExceeded(amount, drink))
            {
                throw new Exception("Too many drinks, max 2.");
            }

            int price;
            if (drink.Equals(ONE_BEER))
            {
                price = 74;
            }
            else if (drink.Equals(ONE_CIDER))
            {
                price = 103;
            }
            else if (drink.Equals(A_PROPER_CIDER)) price = 110;
            else if (drink.Equals(GT))
            {
                price = ingredient6() + ingredient5() + ingredient4();
            }
            else if (drink.Equals(BACARDI_SPECIAL))
            {
                price = ingredient6() / 2 + ingredient1() + ingredient2() + ingredient3();
            }
            else
            {
                throw new Exception("No such drink exists");
            }
            if (student && (drink == ONE_CIDER || drink == ONE_BEER || drink == A_PROPER_CIDER))
            {
                price = price - price / 10;
            }
            return price * amount;
        }

        private bool IsLimitExceeded(int amount, string drink)
        {
            return (amount > 2 && (drink == GT || drink == BACARDI_SPECIAL));
        }

        //one unit of rum
        private int ingredient1()
        {
            return 65;
        }

        //one unit of grenadine
        private int ingredient2()
        {
            return 10;
        }

        //one unit of lime juice
        private int ingredient3()
        {
            return 10;
        }

        //one unit of green stuff
        private int ingredient4()
        {
            return 10;
        }

        //one unit of tonic water
        private int ingredient5()
        {
            return 20;
        }

        //one unit of gin
        private int ingredient6()
        {
            return 85;
        }
    }
}
