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
        //check Foat Maximum Float Number
        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            //comapring First Number to Second Number > 0  and firstNumber to third Number >0  
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                //return 
                return firstValue;
            //comapring Second Number to First Number  > 0  and SecondNumber to third Number >0  
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                //return secondNumber
                return secondValue;
            else
                //return thirdNumber
                return thirdValue;
        }
        public static string MaximumString(string firstString, string secondString, string thirdString)
        {
            //compare 
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
                return firstString;

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
                return secondString;

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
                return thirdString;

            throw new Exception("firstString, secondString and thirdString are same");
        }


    }
}
