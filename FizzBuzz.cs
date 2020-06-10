using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xunitPractice
{
    public class FizzBuzz
    {
        public string AnalyzeNum(int num)
        {
            if (num % 3 ==0 && num % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if(num % 3 == 0)
            {
                return "buzz";
            }
            else
            {
                return "fizz";
            }
        }
    }
}
