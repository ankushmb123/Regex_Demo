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
        static string pattern = "^cen$";
        // ^ : Indicates the starting of string
        // $ : Indicates the end of the string.
        public void Display()
        {
            //we have created object of class
            //we have pass a parameter in given class constructor
            Regex regex = new Regex(pattern);
            //IsMatch return true Otherwise it return false
            if (regex.IsMatch("cen"))
            {
                Console.WriteLine("String matches the pattern");
            }
            else
            {
                Console.WriteLine("string Doesn't matches the pattern");
            }

        }
        public void NameValidate()
        {
            //?-will check value we are using that return the same thing.0 or 1 Occurance
            Console.WriteLine("Enter the First name ");
            string name = Console.ReadLine();
            string firstname = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, firstname))
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
