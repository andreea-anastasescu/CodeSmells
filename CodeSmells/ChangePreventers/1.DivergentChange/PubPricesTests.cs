using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeSmells.ChangePreventers._1.DivergentChange
{
    [TestClass]
    public class PubPricesTest
    {
        Pub pub;

        [ClassInitialize]
        public void setUp()
        {
            pub = new Pub();
        }

        [TestMethod]
        public void OneBeerTest()
        {
            int actualPrice = pub.computeCost(Pub.ONE_BEER, false, 1);
            Assert.AreEqual(74, actualPrice);            
        }

        [TestMethod]
        public void TestStudentsGetADiscountForBeer() 
        {
            int actualPrice = pub.computeCost(Pub.ONE_BEER, true, 1);
            Assert.Equals(67, actualPrice);
        }

        [TestMethod]
        public void TestCidersAreCostly() 
        {
            int actualPrice = pub.computeCost(Pub.ONE_CIDER, false, 1);
            Assert.Equals(103, actualPrice);
        }

    //    @Test
    //    public void testProperCidersAreEvenMoreExpensive() throws Exception
    //    {
    //        int actualPrice = pub.computeCost(Pub.A_PROPER_CIDER, false, 1);
    //        assertEquals(110, actualPrice);
    //    }

    //    @Test
    //    public void testACocktail() throws Exception
    //    {
    //        int actualPrice = pub.computeCost(Pub.GT, false, 1);
    //        assertEquals(115, actualPrice);
    //    }

    //    @Test
    //    public void testThatADrinkNotInTheSortimentGivesError() throws Exception
    //    {
    //        expectedException.expect(RuntimeException.class);
    //        expectedException.expectMessage("No such drink");
    //        pub.computeCost("sanfranciscosling", false, 1);
    //    }

    //@Test
    //    public void testStudentsDoNotGetDiscountsForCocktails() throws Exception
    //{
    //        int actualPrice = pub.computeCost(Pub.GT, true, 1);
    //    assertEquals(115, actualPrice);
    //}

    //@Test
    //    public void testBacardiSpecial() throws Exception
    //{
    //        int actualPrice = pub.computeCost(Pub.BACARDI_SPECIAL, false, 1);
    //    assertEquals(127, actualPrice);
    //}

    //@Test
    //    public void testCanBuyAtMostTwoDrinksInOneGo() throws Exception
    //{
    //    expectedException.expect(RuntimeException.class);
    //        expectedException.expectMessage("Too many");
    //        pub.computeCost(Pub.BACARDI_SPECIAL, false, 3);
    //    }

    //    @Test
    //    public void testStudentsGetDiscountsWhenOrderingMoreThanOneBeer() throws Exception
    //{
    //        int actualPrice = pub.computeCost(Pub.ONE_BEER, true, 2);
    //    assertEquals(67*2, actualPrice);
    //}

    //@Test
    //    public void testCanOrderMoreThanTwoBeers() throws Exception
    //{
    //    pub.computeCost(Pub.ONE_BEER, false, 5);
    //}
    //}
    //}
}
}
