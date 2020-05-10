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

        public void Division()
        {
            throw new NotImplementedException();
        }

        public void SquareRoot()
        {
            throw new NotImplementedException();
        }
    }
}
