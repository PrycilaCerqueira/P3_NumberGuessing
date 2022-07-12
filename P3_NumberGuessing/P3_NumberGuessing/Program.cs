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
            int randomNumber = GetARandomNumber();
            int guessedNumber = 0;

            Console.WriteLine("Let's play! \nYou will have 7 chances to win this game. \nGuess a number between 1 to 100. \n");

            for (int count = 1; count < 8; count++)
            {
                Console.Write($"Guess number {count}: ");
                guessedNumber = Int32.Parse(Console.ReadLine());

                if (guessedNumber == randomNumber)
                {

                }
                
            }
           
        }
    }

    
}
