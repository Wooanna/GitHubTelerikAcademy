using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBASIC
{
    class BasicBASIC
    {
        static void Main()
        {
            List<string> inputLines = new List<string>();

            ReadInput(inputLines);
            ClearWhiteSpaces(inputLines);

        }

        private static List<string> ReadInput(List<string> inputLines)
        {

            string input = "";
            while (input != "RUN")
            {
                input = Console.ReadLine();
                inputLines.Add(input);
            }
            return inputLines;
        }

        private static List<string> ClearWhiteSpaces(List<string> inputLines)
        {
            List<string> replacedWhites = new List<string>();
            foreach (var line in inputLines)
            {
                replacedWhites.Add(line.Replace(" ", ""));
            }

            for (int i = 0; i < replacedWhites.Count; i++)
            {
                CommandsExecution(replacedWhites[i]);
            }

            return replacedWhites;

        }

        private static void CommandsExecution(string currentCommand)
        {
            int V = 0;
            int W = 0;
            int X = 0;
            int Y = 0;
            int Z = 0;
            string identifyer = currentCommand[0];
            if (char.IsDigit(currentCommand[1]))
            {
                
            }
            
            for (int i = 0; i < currentCommand.Length; i++)
            {
                if (char.IsDigit(currentCommand[i]) )
                {
                    
                }
            }






        }
    }
}
