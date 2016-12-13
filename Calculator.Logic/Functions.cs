using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    public static class Functions
    {
      

        public static decimal NullFunction(decimal num1, decimal num2)
        {
            return new decimal();
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            //Console.WriteLine(num1 + num2);
            return num1 + num2;
        }

        public static decimal Subtract(decimal num1, decimal num2)
        {
            //Console.WriteLine(num1 - num2);
            return num1 - num2;
        }
    }

}
