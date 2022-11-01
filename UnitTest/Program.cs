
using System;

namespace MyNamespace
{
    public class Calculator
    {
        public int add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }


        public int Division(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException("Divide by 0");
            }

            return number1 / number2;
        }
       
    }
}
