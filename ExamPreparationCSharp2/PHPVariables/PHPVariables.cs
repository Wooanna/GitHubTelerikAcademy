using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPVariables
{
    class PHPVariables
    {
        public static string ReadInput()
        {
            string currentLine = Console.ReadLine();
            StringBuilder phpCode = new StringBuilder();

            while (currentLine != "?>")
            {
                phpCode.AppendLine(currentLine);
                currentLine = Console.ReadLine().Trim();
            }

            string result = phpCode.ToString();

            return result;

        }

        public static bool isValidVariableSymbol(char symbol)
        {
            if (char.IsLetterOrDigit(symbol) || symbol == '_')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static HashSet<string> ExtractWords(string inputCode)
        {
            bool inOneLineComment = false;
            bool inMultilineComment = false;
            bool inSingleQuoteString = false;
            bool inDoubleQuoteString = false;
            bool inVariable = false;
            StringBuilder variable = new StringBuilder();
            HashSet<string> allVariables = new HashSet<string>();

            for (int i = 0; i < inputCode.Length; i++)
            {
                char currentSymbol = inputCode[i];
                //we are in one line comment
                if (inOneLineComment)
                {
                    if (currentSymbol == '\n')
                    {
                        inOneLineComment = false;
                        continue;
                    }
                }

                //we are in multiline comment
                if (inMultilineComment)
                {
                    if (currentSymbol == '*' &&
                        ((i + 1) < inputCode.Length)
                        && inputCode[i + 1] == '/')
                    {
                        inMultilineComment = false;
                        i++;
                        continue;
                    }
                }

                if (inVariable)
                {
                    if (isValidVariableSymbol(currentSymbol))
                    {
                        variable.Append(currentSymbol);
                        continue;
                    }
                    else
                    {
                        if (variable.Length > 0)
                        {
                            allVariables.Add(variable.ToString());
                        }
                        variable.Clear();
                        inVariable = false;
                    }
                }

                if (inSingleQuoteString)
                {
                    if (currentSymbol == '\'')
                    {
                        inSingleQuoteString = false;
                        continue;
                    }
                }

                if (inDoubleQuoteString)
                {
                    if (currentSymbol == '\"')
                    {
                        inDoubleQuoteString = false;
                        continue;
                    }
                }

                if (!inSingleQuoteString && !inDoubleQuoteString)
                {
                    if (currentSymbol == '#')
                    {
                        inOneLineComment = true;
                        continue;
                    }
                    if (currentSymbol == '/' &&
                        i + 1 < inputCode.Length
                        && inputCode[i + 1] == '/')
                    {
                        inOneLineComment = true;
                        i++;
                        continue;
                    }
                    if ( currentSymbol == '/' && 
                        i+ 1 < inputCode.Length 
                        && inputCode[i + 1]  == '*')
                    {
                        inMultilineComment = true;
                        i++;
                        continue;
                    }
                }
                else
                {
                    if (currentSymbol == '\\')
                    {
                        i++;
                        continue;
                    }
                }
                if (currentSymbol == '"')
                {
                    inDoubleQuoteString = true;
                    continue;
                }
                if (currentSymbol == '\'')
                {
                    inSingleQuoteString = true;
                    continue;
                }

                if (currentSymbol == '$' && (!inMultilineComment && !inOneLineComment) )
                {
                    inVariable = true;
                    continue;
                }
            }
            return allVariables;
        }

        static void Main()
        {
            string inputCode = ReadInput();
            var result = ExtractWords(inputCode);
            PrintResult(result);
                   
        }

         static void PrintResult(HashSet<string> result)
        {
            Console.WriteLine(result.Count);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
