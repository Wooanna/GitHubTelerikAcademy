using System;

class ExcelColumns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long result = 0;
        for (int i = 0; i < n; i++)
        {
            result += (Convert.ToChar(Console.ReadLine()) - 64) * (long)Math.Pow(26, n - i - 1);
        }
        Console.WriteLine(result);
    }
}