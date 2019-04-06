using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer3
{
    public class RomanToNumberConvertor
    {
        Dictionary<string, int> allNumbers = new Dictionary<string, int>()
        {
            { "M", 1000},
            { "D", 500 },
            { "C", 100 },
            { "L", 50 },
            { "X", 10 },
            { "V", 5 },
            { "I", 1 },
        };

        public int ToNumber(string romanInput)
        {
            if (romanInput.Length == 0) return 0;
                romanInput = romanInput.ToUpper();

            {
                int number = 0;
                for (int i = 0; i < romanInput.Length; i++)
                {
                    if (i + 1 < romanInput.Length && 
                        allNumbers[romanInput[i].ToString()] < allNumbers[romanInput[i + 1].ToString()])
                    {
                        number -= allNumbers[romanInput[i].ToString()];
                    }
                    else
                    {
                        number += allNumbers[romanInput[i].ToString()];
                    }
                }
                return number;

            }
        }
    }
}
