using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    public class MaxNumberCheck
    {
        //check Foat Maximum int Number
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        //comapring First Number to Second Number > 0  and firstNumber to third Number >0  
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            //comapring Second Number to First Number  > 0  and SecondNumber to third Number >0  
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                //return secondNumber
                return secondValue;
            else
                //return thirdNumber
                return thirdValue;

        }

    }
}
