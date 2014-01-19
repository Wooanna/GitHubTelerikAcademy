using System;

    class AstrologicalNumbers
    {
        static void Main()
        {
            string N = Console.ReadLine();

            
            N = N.Replace("-", "");
            N = N.Replace(".", "");

            int result = 0;
            while (true)
            {                
                for (int i = 0; i < N.Length; i++)
                {
                    int digit = int.Parse(N[i].ToString());
                    result += digit;
                }
                if (result>9)
                {
                    N = result.ToString();
                    result = 0;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(result);
            

        }
    }

