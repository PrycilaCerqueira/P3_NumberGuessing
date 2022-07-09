using System;

namespace P3_NumberGuessing // Note: actual namespace depends on the project name.
{
    internal class Program
    {


        static int sortARandomNumber()
        {
            Random draw = new Random();
            int drawedNumber = draw.Next(100);
            return drawedNumber;
        }


        static void Main(string[] args)
        {
           Console.WriteLine(sortARandomNumber());
        }
    }

    
}