using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> 
//should be recognized as emails.

  class ExtractEmail
    {
        static void Main()
        {
            string str = "Static void Main() nakov@telerik.com. using System,nakov@gmail.com return";

            foreach (var item in Regex.Matches(str, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }

