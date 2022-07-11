using System;

namespace P3_NumberGuessing // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        //Function to get a Random number for the main program
        static int GetARandomNumber()
        {
            Random draw = new Random();
            int drawedNumber = draw.Next(1, 101);
            return drawedNumber;
        }


        //Main program
        static void Main(string[] args)
        {
            Console.WriteLine(GetARandomNumber());

        }
    }

    
}
