using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class stars
    {
        static int height, width, depth;
        static char[,,] cube;
        static Dictionary<char, int> starType = new Dictionary<char, int>();
        static int starCount = 0;
        static void Main()
        {
            ReadInput();
            FindStars();
            PrintInput();


        }

        private static void PrintInput()
        {
            var sorted = starType.OrderBy(x => x.Key);

            Console.WriteLine(starCount);
            foreach (var star in sorted)
            {
                Console.WriteLine("{0} {1}", star.Key, star.Value);
            }
        }

        private static void FindStars()
        {
            for (int w = 1; w < width - 1; w++)
            {
                for (int h = 1; h < height - 1; h++)
                {
                    for (int d = 1; d < depth - 1; d++)
                    {
                        FindSingleStar(w, h, d);
                    }
                }
            }
        }

        private static void FindSingleStar(int w, int h, int d)
        {
            
            char currChar = cube[w, h, d];
            bool isStar =
                currChar == cube[w -1, h, d] &&
                currChar == cube[w + 1, h, d] &&
                 currChar == cube[w, h - 1, d] &&
                currChar == cube[w, h + 1, d] &&
                 currChar == cube[w, h, d - 1] &&
                currChar == cube[w, h, d + 1];

            if (isStar)
            {
                starCount++;
                if (starType.ContainsKey(currChar))
                {
                    starType[currChar]++;
                }
                else
                {
                    starType.Add(currChar, 1);
                }
            }

        }

        private static void ReadInput()
        {
            string[] dimentions = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            width = int.Parse(dimentions[0]);
            height = int.Parse(dimentions[1]);
            depth = int.Parse(dimentions[2]);
            cube = new char[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string[] LineFragment = Console.ReadLine().Split();
                for (int d = 0; d < depth; d++)
                {
                    string cubeContent = LineFragment[d];
                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }
            }
        }
    }

