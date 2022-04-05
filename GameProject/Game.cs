using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProject
{
    public class Game
    {
        private Player player1;
        private Player player2;

        public void Play()
        {
            AskUserThinkOrGuess();
            System.Console.WriteLine("Player " + player1.Name + " think a number.");
            int secretNumber = player1.GenNumber();

            bool gameOver = false;
            int nGuess = 0;
            while(!gameOver)
            {
                int guessNumber = player2.GuessNumber();
                nGuess++;

                System.Console.WriteLine("Player " + player2.Name + " guess " + guessNumber);
                gameOver = CompareNumbers(guessNumber, secretNumber);
                if (nGuess == 3) gameOver = true;
            }
            System.Console.WriteLine("Game over!");
            
        }
        private bool CompareNumbers(int guessNumber, int secretNumber)
        {
            bool gameOver = false;
            if (guessNumber < secretNumber)
            {
                System.Console.WriteLine("Guess number is less than secret number");
                UpdateLastGuess(Computer.LESS_THAN);
            }
            else if (guessNumber > secretNumber)
            {
                System.Console.WriteLine("Guess number is greater than secret number");
                UpdateLastGuess(Computer.GREATER_THAN);
            }
            else 
            {
                System.Console.WriteLine("Correct guess.");
                System.Console.WriteLine("Player " + player2.Name + " win!");
                gameOver = true;
            }
            
            return gameOver;
        }
        private void UpdateLastGuess(int lastGuess)
        {
            if (player2 is Computer) 
            {
                ((Computer)player2).LastGuess = lastGuess;
            }
        }

        private void AskUserThinkOrGuess()
        {
            System.Console.Write("Think or guess? ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "think")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else
            {
                player2 = new Human();
                player1 = new Computer();
            }
        }
    }
}