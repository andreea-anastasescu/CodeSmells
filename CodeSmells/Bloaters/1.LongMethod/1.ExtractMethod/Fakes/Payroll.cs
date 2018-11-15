using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells.Bloaters.LongMethod.ExtractMethod.Fakes
{
    public class Payroll
    {

            public string Name { set; get; }
        public string Tax { get; internal set; }
        public string Gross { get; internal set; }
    }
}
