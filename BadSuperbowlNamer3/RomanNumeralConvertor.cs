using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer3
{
    public class RomanNumeralConvertor
    {
        Dictionary<int, string> allNumbers = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL"},
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        public string ToRoman(int userInput)
        {
            var romanNumeral = "";

            foreach (var number in allNumbers)
            {
                while(userInput >= number.Key && userInput > 0) {
                    userInput -= number.Key;
                    romanNumeral += number.Value;
                }
            }
            return romanNumeral;
        }
    }
}
