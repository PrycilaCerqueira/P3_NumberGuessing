using System;

namespace P3_NumberGuessing // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random draw = new Random();
            int drawedNumber = draw.Next(1, 21);
            int guessedNumber = 0;
            

            Console.WriteLine("Let's play! \nYou will have 5 chances to win this game. \nGuess a number between 1 to 100. \n");

            //For to iterantes through 5 times
            for (int count = 1; count <= 6; count++)
            {
                //Validates whether or not the player reached their limited tries 
                if (count == 6)
                {
                    Console.WriteLine($"You lose -.- \nThe correct number was {drawedNumber}.");
                }

                //The player continues to play if they haven't surpassed 5 times
                else
                {
                    Console.Write($"Guess number {count}: ");
                    guessedNumber = Int32.Parse(Console.ReadLine());
                    int distance = Math.Abs(drawedNumber - guessedNumber);

                    //Verifies whether or not the guessed number is between 1 to 100
                    if (guessedNumber < 1 || guessedNumber > 100)
                    {
                        Console.WriteLine("The number inserted is out of range. Please, try again!");
                    }

                    else
                    {

                        if (guessedNumber == drawedNumber)
                        {
                            Console.WriteLine($"Congratulations!!! You guessed the right number {drawedNumber}.");
                            break;
                        }
                        //if (guessedNumber >= (drawedNumber - 5) && guessedNumber <= (drawedNumber + 5))
                        if (distance <= 5)
                        {
                            Console.WriteLine("You are close! ");
                        }
                        if (guessedNumber < drawedNumber)
                        {
                            Console.WriteLine("Your guess was too low.");
                        }
                        if (guessedNumber > drawedNumber)
                        {
                            Console.WriteLine("Your guess was too high.");
                        }
                    }  
                }
               

            }
            
           
        }
    }

    
}
