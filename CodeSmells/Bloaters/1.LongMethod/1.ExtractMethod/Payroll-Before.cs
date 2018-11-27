using CodeSmells.Bloaters.LongMethod.ExtractMethod.Fakes;
using System;

namespace CodeSmells.Bloaters.LongMethod.ExtractMethod
{
    public  class PayrollPrinter
    {

        public void Print( Payroll payroll)
        {
            PrintHeader();

            //print details
            Console.WriteLine("name: " + payroll.Name);
            Console.WriteLine("gross salary: " + payroll.Gross);
            Console.WriteLine("tax " + payroll.Tax);
            //...
        }


        private void PrintHeader()
        {
            Console.WriteLine("*************");
            //...
        }




    }


    
}
