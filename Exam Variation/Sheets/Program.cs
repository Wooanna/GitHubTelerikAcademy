using System;

    class Program
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int bit = (input >> i) & 1;
                if (bit != 1)
                {
                    Console.WriteLine("A{0}", 10 - i);
                }
            }

            


     
    }
}
