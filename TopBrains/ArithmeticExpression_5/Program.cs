using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string in the form of (a op b): ");
        string exp = Console.ReadLine();

        string[] expArray = exp.Split(" ");
        try
        {
            if(expArray.Length >3 || expArray.Length<3)
            {
                throw new Exception("InvalidExpression");
            }
            if (!expArray[0].All(Char.IsDigit) && ! expArray[2].All(Char.IsDigit))
            {
                throw new Exception("InvalidNumber");
            }

        
        int num1 = Convert.ToInt32(expArray[0]);
        int num2 = Convert.ToInt32(expArray[2]);


        string op = expArray[1];
            if(op.Equals("/"))
            {
                if(num2 == 0)
                {
                    throw new Exception(" DivideByZero");
                }
                System.Console.WriteLine(exp + " : " + num1 / num2);
            }
            else if(op.Equals("*"))
            {
                System.Console.WriteLine(exp + " : " + num1 * num2);
            }
            else if(op.Equals("+"))
            {
                System.Console.WriteLine(exp + " : " + num1 + num2);
            }
            else if(op.Equals("-"))
            {
                System.Console.WriteLine(exp + " : " + (num1-num2));
            }
            else
            {
                throw new Exception("UnknownOperator");
            }


        }
        catch(Exception e)
        {
            Console.WriteLine("Error: "+ e.Message);
        }
    }
}
