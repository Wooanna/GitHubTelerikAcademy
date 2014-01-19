using System;

//You are given an array of strings. Write a method that sorts the array by the length of its elements
//(the number of characters composing them).

class SortStringArray
{
    static void Main()
    {
        string[] array = new string[] { "Glad to see you tonight", "Welcome", "How are you?", "Hello", 
            "How was your day?", "Nice to meet you", "Hey" };
        Array.Sort(array, (x, y) => (x.Length.CompareTo(y.Length)));
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

