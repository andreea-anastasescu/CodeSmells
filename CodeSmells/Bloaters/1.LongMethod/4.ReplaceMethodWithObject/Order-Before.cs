namespace CodeSmells.Bloaters.LongMethod.ReplaceMethodWithObject
{
    class Order_Before
    {

        public class Order
        {
            //...
            public double Price()
            {
                double primaryBasePrice;
                double secondaryBasePrice;
                double tertiaryBasePrice;
                // long computation.
                //...

                return 0; // :-)
            }
        }
    }
}
