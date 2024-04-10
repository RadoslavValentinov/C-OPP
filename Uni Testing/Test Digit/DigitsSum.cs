using System;
using System.Collections.Generic;
using System.Text;

namespace TestingDemo
{
    public class DigitsSum
    {
        public DigitsSum(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }


        public int ValidSum(int first,int secont)
        {
            var result = first + secont;
            return result;
        }
    }
}
