﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteTestWords
{
    static void Main()
    {
       
   using (StreamReader input = new StreamReader("text.txt"))
        using (StreamWriter output = new StreamWriter("result.txt"))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));


    }
}

