using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL address given in the format

class ExtractsURL
{
    public static void ExtractURL(string url)
    {
        int index = 0;
        index = url.IndexOf(':');
        Console.WriteLine("[protocol] = \"{0}\"", url.Substring(0, index));
        url = url.Replace(url.Substring(0, index + 3), "");

        index = url.IndexOf('/');
        Console.WriteLine("[server] = \"{0}\"", url.Substring(0, index));
        url = url.Replace(url.Substring(0, index), "");

        Console.WriteLine("[resource] = \"{0}\"", url);

    }

    static void Main()
    {
        string url = "http://dkeray.wordpress.com/2012/12/30/c-exam-2012-problem-4-uk-flag/";
        ExtractURL(url);
    }
}