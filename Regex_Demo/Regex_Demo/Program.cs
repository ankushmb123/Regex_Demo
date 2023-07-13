using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Regex_Demo
{
    public class program
    {
        public static void Main(string[] args)
        {
            {
                static void Main(string[] args)
                {
                    Regex_Display regexDisplay = new Regex_Display();

                    while (true)
                    {
                        Console.WriteLine("*****************");
                        Console.WriteLine("1-Regex");
                        Console.WriteLine("2-Validate first name");
                        Console.WriteLine("3-Validate last name");
                        Console.WriteLine("4-Phone Number");
                        Console.WriteLine("*****************");
                        Console.WriteLine("Choose the Above options");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                regexDisplay.Display();
                                Console.WriteLine("*****************");
                                break;
                            case 2:
                                regexDisplay.NameValidate();
                                Console.WriteLine("*****************");
                                break;
                            case 3:
                                regexDisplay.Last_NameValidate();
                                Console.WriteLine("*****************");
                                break;
                            case 4:
                                regexDisplay.PhoneNumber();
                                Console.WriteLine("*****************");
                                break;

                            default:
                                Console.WriteLine("Invalid option");
                                break;

                        }

                    }
                }
            }
        }
    }
}



