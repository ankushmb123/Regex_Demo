using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
  
    //A Regex(Regular Expression) is a pattern that used to check wheather a given string 
    //matches that pattern
    public class Regex_Display
    {
        static string pattern = "^ce$";
        // ^ : Indicates the starting of string
        // $ : Indicates the end of the string.
        public void Display()
        {
            //we have created object of class
            //we have pass a parameter in given class constructor
            Regex regex = new Regex(pattern);
            if (regex.IsMatch("cen"))
            {
                Console.WriteLine("String matches the pattern");
            }
            else
            {
                Console.WriteLine("string Doesn't matches the pattern");
            }

        }
    }
}