using System.ComponentModel;
using SWtest_calculator_EX;

namespace SWtest_calculator_EX
{


    public class program
    {
        static void Main()
        {
            Calc CalcOne = new Calc();

            //Add test
            Console.WriteLine("Input 2 numbers, you dumb bitch!");

            string userinput1 = Console.ReadLine();
            string userinput2 = Console.ReadLine();

            double a = double.Parse(userinput1);
            double b = double.Parse(userinput2);

            double result = CalcOne.Add(a, b);
            Console.WriteLine("Result is: {0}", result);
            Console.WriteLine("Accumulator is {0}", CalcOne.Accumulator);






        }



    }
}