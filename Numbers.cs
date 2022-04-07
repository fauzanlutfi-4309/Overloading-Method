using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int minimum;

            if (number1 < number2)
            {
                minimum = number1;
            } else
            {
                minimum = number2;
            }

            return minimum;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int minimum;

            if ((number1 < number2) && (number1 < number3))
            {
                minimum = number1;
            } else if ((number2 < number1) && (number2 < number3))
            {
                minimum = number2;
            } else
            {
                minimum = (int)number3;
            }

            return minimum;
        }

        public int FindMaximum(int number1, int number2)
        {
            int maximum;

            if (number1 > number2)
            {
                maximum = number1;
            }
            else
            {
                maximum = number2;
            }

            return maximum;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int maximum;

            if ((number1 > number2) && (number1 > number3))
            {
                maximum = number1;
            }
            else if ((number2 > number1) && (number2 > number3))
            {
                maximum = number2;
            }
            else
            {
                maximum = (int)number3;
            }

            return maximum;
        }
    }
}
