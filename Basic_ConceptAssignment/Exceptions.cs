using System;
namespace Assignment2
{
    public class Exceptions
    {
        public static void Operations()
        {
            try {
                Console.WriteLine("Enter the first number:");
                string num1 = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string num2 = Console.ReadLine();

                Console.WriteLine("Enter the operation");
                string op = Console.ReadLine();

                if (op == "+" || op == "-" || op == "*" || op == "/")
                {
                    int num11;
                    int num22;
                    if (int.TryParse(num1,out num11)&& int.TryParse(num2,out num22))
                    {
                        if (op == "+") Console.WriteLine(num11 + num22);
                        else if (op == "-") Console.WriteLine(num11 - num22);
                        else if (op == "*") Console.WriteLine(num11 * num22);
                        else if (op == "/")
                        {
                            if (num22 == 0)
                            {
                                throw new DivideByZeroException("number cannot be divide by zero");
                            } else
                                Console.WriteLine(num11 / num22);
                        }
                    }
                    else throw new InvalidNumberException("Number is invalid, the number should be in int format");
                }
                else throw new UnknownOperatorException("Operator is unknow");
            }
            catch (InvalidNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnknownOperatorException e)
            {
                Console.WriteLine(e.Message);
            }

            }
        }
    public class UnknownOperatorException : Exception
    {
        public UnknownOperatorException() { }
        public UnknownOperatorException(string message): base(message) { }
    }
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException() { }
        public InvalidNumberException(string message) : base(message) { }
    }
    public class DivideByZeroException : Exception
    {
        public DivideByZeroException() { }
        public DivideByZeroException(string message): base(message) { }
    }
}