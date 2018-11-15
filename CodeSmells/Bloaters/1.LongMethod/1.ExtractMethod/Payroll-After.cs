using CodeSmells.Bloaters.LongMethod.ExtractMethod.Fakes;
using System;


namespace CodeSmells.Bloaters.LongMethod.ExtractMethod
{
    public  class PayrollPrinter2
    {

        public void Print( Payroll payroll)
        {
            PrintHeader();

            PrintDetails(payroll);            
        }


        private void PrintHeader()
        {
            //Console.WriteLine("*************");
            //...
        }

        private void PrintDetails(Payroll payroll)
        {
            Console.WriteLine("name: " + payroll.Name);
            Console.WriteLine("gross salary: " + payroll.Gross);
            Console.WriteLine("tax " + payroll.Tax);
            //...
        }




    }


    
}
