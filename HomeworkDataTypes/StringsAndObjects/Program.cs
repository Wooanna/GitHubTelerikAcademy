using System;


namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concatenation = (hello +" " + world + " !");
            Console.WriteLine(concatenation);

            string text = concatenation.ToString();
            Console.WriteLine(text);


        }
    }
}
