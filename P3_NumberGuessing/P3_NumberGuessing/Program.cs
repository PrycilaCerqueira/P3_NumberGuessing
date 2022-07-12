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

            Console.WriteLine("Let's play! \nYou will have 5 chances to win this game. \nGuess a number between 1 to 100. \n");

            for (int count = 1; count <= 6; count++)
            {
                if (count == 6)
                {
                    Console.WriteLine($"You lose -.- \nThe correct number was {randomNumber}.");
                }
                else
                {
                    Console.Write($"Guess number {count}: ");
                    guessedNumber = Int32.Parse(Console.ReadLine());

                    if (guessedNumber + 5 == randomNumber || guessedNumber - 5 == guessedNumber)
                    {
                        Console.WriteLine("You are close! ");
                    }
                    else
                    {
                        if (guessedNumber < randomNumber)
                        {
                            Console.WriteLine("Your guess was too low.");
                        }
                        if (guessedNumber > randomNumber)
                        {
                            Console.WriteLine("Your guess was too high.");
                        }
                        if (guessedNumber == randomNumber)
                        {
                            Console.WriteLine($"Congratulations!!! You guessed the right number {randomNumber}.");
                            break;
                        }
                    }
                }
                    

            }
            
           
        }
    }

    
}
