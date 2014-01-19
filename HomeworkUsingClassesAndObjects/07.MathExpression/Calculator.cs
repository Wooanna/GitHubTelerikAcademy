namespace MathExpression
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Threading;
    class Calculator
    {
        public static List<char> arithmeticOperation = new List<char>() {'-', '+', '/', '*' };
        public static List<string> functions = new List<string>() { "ln", "pow", "sqrt"};
        public static string TrimInput(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }

        public static List<string> SeparateTokens(string input)
        {

            List<string> result = new List<string>();
            var number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
                {
                    number.Append('-');

                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }
                //brackets
                else if (input[i] == '(')
                {
                    result.Add("(");
                }
                else if (input[i] == ')')
                {
                    result.Add(")");
                }
                else if (arithmeticOperation.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (input[i] == ',')
                {
                    result.Add(",");
                }
                else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
                {
                    result.Add("pow");
                    i += 2;
                }
                else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression");
                }
            }

                if (number.Length != 0)
                {
                    result.Add(number.ToString());
                }

            
            return result;

        }

        public static int Precedence(string arithmeticOperator)
        {
            if (arithmeticOperator == "+" || arithmeticOperator == "-")
                return 1;
            
            else return 2;
        }
        public static Queue<string> ConvertToPolishNotation(List<string> tokens)
        {
            Stack<string> stack= new Stack<string>();
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < tokens.Count; i++)
            {
                var currentToken = tokens[i];
                double number;

                if (double.TryParse(currentToken, out number))
                {
                    queue.Enqueue(currentToken);
                }
                else if (stack.Count != 0 && functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                else if (functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                else if (currentToken == ",")
                {
                    if (!stack.Contains( "(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid brackets function separator");
                    }

                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
                else if (arithmeticOperation.Contains(currentToken[0]))
                {
                    while (stack.Count != 0 && arithmeticOperation.Contains(stack.Peek()[0])
                     &&  Precedence(currentToken) <= Precedence(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Push(currentToken);
                    
                }
                else if (currentToken == "(")
                {
                    stack.Push("(");//?
                }
                else if (currentToken == ")")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid parenthesis position");
                    }
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Pop(); // pop the left parenthesis, but not onto the queue!!

                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }

            while (stack.Count != 0)
            {
                if (stack.Peek() == "(" || stack.Peek() == ")")
                {
                    throw new ArgumentException("Ïnvalid brackets position");
                }
                queue.Enqueue( stack.Pop());
            }
            return queue;
        }
        public static void PutInvariantCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }
        public static double GetResultFromRPN(Queue<string> queue)
        {
            Stack<double> stack = new Stack<double>();
            while (queue.Count != 0)
            {
                double number;
                string currentToken = queue.Dequeue();
                if (double.TryParse(currentToken, out number))
                {
                    stack.Push(number);
                }
                else if(arithmeticOperation.Contains(currentToken[0]) || functions.Contains(currentToken))
                {
                    if (currentToken == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid espression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue + secondValue);
                    }
                    else if (currentToken == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid espression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue - firstValue);
                    }
                    else  if (currentToken == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid espression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue * firstValue);
                    }

                    else if (currentToken == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid espression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue / firstValue);
                    }
                    else if (currentToken == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid espression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(Math.Pow(secondValue, firstValue));
                    }
                    else if (currentToken == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid espression");
                        }
                        double value = stack.Pop();

                        stack.Push(Math.Sqrt(value));
                    }
                    if (currentToken == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid espression");
                        }
                        double value = stack.Pop();

                        stack.Push(Math.Log(value));
                    }


                }
            }
            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression");
            }
        }
        static void Main(string[] args)
        {
            PutInvariantCulture();
            Console.WriteLine("Enter your expression");

            string input = Console.ReadLine().Trim();
           
                try
                {
                    string TrimmedInput = TrimInput(input);

                    //Console.WriteLine(TrimmedInput);
                    var separatedTokens = SeparateTokens(TrimmedInput);
                    var reversePolishNotation = ConvertToPolishNotation(separatedTokens);
                    var finalResult = GetResultFromRPN(reversePolishNotation);
                    Console.WriteLine("Result: {0:F2}", finalResult);
                }
                catch (ArgumentException exeption)
                { Console.WriteLine(exeption.Message); }
                
            
            

         }
    }
}
