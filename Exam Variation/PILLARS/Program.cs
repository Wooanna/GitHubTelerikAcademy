using System;

class PILLARS
{
    static void Main()
    {
        //int[] nNumbers = new int[8];

        //for (int i = 0; i < 8; i++)
        //{
        //    nNumbers[i] = int.Parse(Console.ReadLine());

        //}       

        int n0 = int.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        int n6 = int.Parse(Console.ReadLine());
        int n7 = int.Parse(Console.ReadLine());
        int pillar = 7;
        int countBits = 0;
        int leftCount = 0;
        int rightCount = 0;
        bool isPillarFound = false;


        for (int index = 7; index >= 0; index--)
        {
            leftCount = 0;
            for (int leftColumn = 7; leftColumn > index; leftColumn--)
            {
                leftCount += (n0 >> leftColumn) & 1;
                leftCount += (n1 >> leftColumn) & 1;
                leftCount += (n2 >> leftColumn) & 1;
                leftCount += (n3 >> leftColumn) & 1;
                leftCount += (n4 >> leftColumn) & 1;
                leftCount += (n5 >> leftColumn) & 1;
                leftCount += (n6 >> leftColumn) & 1;
                leftCount += (n7 >> leftColumn) & 1;

            }

            rightCount = 0;
            for (int rightColumn = index - 1; rightColumn >= 0; rightColumn--)
            {

                rightCount += (n0 >> rightColumn) & 1;
                rightCount += (n1 >> rightColumn) & 1;
                rightCount += (n2 >> rightColumn) & 1;
                rightCount += (n3 >> rightColumn) & 1;
                rightCount += (n4 >> rightColumn) & 1;
                rightCount += (n5 >> rightColumn) & 1;
                rightCount += (n6 >> rightColumn) & 1;
                rightCount += (n7 >> rightColumn) & 1;
            }
            if (leftCount == rightCount)
            {
                pillar = index;
                countBits = leftCount;
                isPillarFound = true;
                break;
        }

            }
            if (isPillarFound == false)
            {
                Console.WriteLine("No");

            }
            else
            {
                Console.WriteLine("{0}\n{1}", pillar, countBits);
            }



    }
}

