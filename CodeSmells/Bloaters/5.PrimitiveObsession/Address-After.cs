using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells.Bloaters._5.PrimitiveObsession
{
    
    public class Address_After
    {
        public ZipCode ZipCode { get; set; }
    }

    public class ZipCode
    {
        private readonly string _value;

        public ZipCode(string value)
        {
            // perform regex matching to verify XXXXX or XXXXX-XXXX format
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

        public static implicit operator string(ZipCode zipCode)
        {
            return zipCode.Value;
        }

        public static explicit operator ZipCode(string value)
        {
            return new ZipCode(value);
        }
        
    }



}
