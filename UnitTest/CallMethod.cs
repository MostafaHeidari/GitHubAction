using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;

namespace CalculatorNameSpace
{
    internal class CallMethod
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// product one
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Add test " + calculator.add(20,10));
            Console.WriteLine("Subtract test " + calculator.Subtract(20,10));
        }
    }
}
