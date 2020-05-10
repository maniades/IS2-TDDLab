using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalcEngine
    {
        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiplication(int value1, int value2)
        {
            return value1 * value2;
        }

        public double Division(int value1, int value2)
        {
            if(value2 == 0)
            {
                throw new DivideByZeroException();
            }

            return (double)value1 / (double)value2;
        }

        public double SquareRoot(int value)
        {
            double result = 0;

            if(value < 0)
            {
                throw new ArgumentException("Value must be possitive");
            }

            double increment = 1;

            while(value - result * result >= 0.00001)
            {
                if((result + increment) * (result + increment) > value)
                {
                    // make increment less
                    increment = increment / 10;
                }
                else
                {
                    result += increment;
                }
            }

            return result;
        }
    }
}
