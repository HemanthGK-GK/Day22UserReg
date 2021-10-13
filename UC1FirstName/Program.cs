using System;
using System.Text.RegularExpressions;

namespace UC1FirstName
{
   
        public class ChkFirstName
        {
            public string RegexFirstName = "^[A-Z]{1}[a-z]{2,}$";
            public bool Validate(string firstname)
            {
                if (firstname == null)
                {
                    throw new CustomException(CustomException.ExceptionsType.Invalid_Data, "Invalid FirstName");
                }
                return Regex.IsMatch(firstname, RegexFirstName);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }

        }
    }

