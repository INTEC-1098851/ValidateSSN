using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSN
{
    public class Validation
    {
        public string ReadSSN()
        {
            string intValue = "";
            ConsoleKeyInfo key= Console.ReadKey(true);
            while (key.Key != ConsoleKey.Enter)
            {
                if(key.Key!= ConsoleKey.Backspace)
                {
                    string numKey = "";
                    switch (key.Key)
                    {
                        case ConsoleKey.D0:
                            Console.Write("0");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad0:
                            Console.Write("0");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D1:
                            Console.Write("1");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad1:
                            Console.Write("1");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D2:
                            Console.Write("2");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad2:
                            Console.Write("2");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D3:
                            Console.Write("3");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad3:
                            Console.Write("3");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D4:
                            Console.Write("4");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad4:
                            Console.Write("4");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D5:
                            Console.Write("5");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad5:
                            Console.Write("5");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D6:
                            Console.Write("6");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad6:
                            Console.Write("6");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D7:
                            Console.Write("7");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad7:
                            Console.Write("7");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D8:
                            Console.Write("8");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad8:
                            Console.Write("8");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.D9:
                            Console.Write("9");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.NumPad9:
                            Console.Write("9");
                            intValue += key.KeyChar;
                            break;
                        case ConsoleKey.Subtract:
                            Console.Write("-");
                            intValue += key.KeyChar;
                            break;
                    }
                }
                else
                {
                    if (intValue.Length > 0)
                    {
                        intValue = intValue.Remove(intValue.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                if (intValue.Length == 11)
                    break;
                key = Console.ReadKey(true);
            }
            Console.WriteLine();
            return intValue;
        }
        public void ValidateSSN(string ssn)
        {
            bool isValid = true;
            if (!ValidateFirstPart(ssn.Substring(0, 3)))
            {
                isValid= false;
                Console.WriteLine("\n The first part of the SSN should not be 000, 666 or between 900 and 999");
            }
            if (ssn[3] != '-')
            {
                isValid = false;
                Console.WriteLine("\n It should have a hyphen (-) after the first 3 digits");
            }
            if (!ValidateSecondPart(ssn.Substring(4, 2)))
            {
                isValid = false;
                Console.WriteLine("\n The second part should be from 01 to 99.");
            }
            if(ssn[6] != '-')
            {
                isValid = false;
                Console.WriteLine("\n It should have a hyphen (-) after the second 2 digits");
            }

            if(!ValidateThirdPart(ssn.Substring(7, 4)))
            {
                isValid = false;
                Console.WriteLine("\n The third part should have 4 digits and it should be from 0001 to 9999");
            }
            if (isValid)
                Console.WriteLine("\n The Social Security Number (SSN) is valid.");
        }

        private bool ValidateFirstPart(string value)
        {
            int number;
            bool res = int.TryParse(value,out number);
            if (value == "000" || value == "666" || !res)
                return false;
            if (res && Enumerable.Range(900, 999).Contains(number))
                return false;
            return true;
        }

        private bool ValidateSecondPart(string value)
        {

            int number;
            bool res = int.TryParse(value, out number);
            if (!res)
                return false;
            if (!Enumerable.Range(01, 99).Contains(number))
                return false;
            return true;
        }

        private bool ValidateThirdPart(string value)
        {
            int number;
            bool res = int.TryParse(value, out number);
            if (!res)
                return false;
            if (!Enumerable.Range(01, 9999).Contains(number))
                return false;
            return true;
        }
    }
}
