using System;

namespace GameProject
{
    public class Human : Player
    {
        public Human() : base("Human")
        {
            // Name = "Human";
        }
        public Human(string name) : base(name)
        {
            // nothing todo
        }
        public override int GenNumber()
        {
            int number = AskNumber("What number do you think? ");
            return number;
        }

        public override int GuessNumber()
        {
            return AskNumber("What number do you guess? ");
        }

        private int AskNumber(string prompt)
        {
            bool invalidInput = true;
            int number = -1;

            while (invalidInput)
            {
                System.Console.Write(prompt);
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 && number > 10)
                    System.Console.WriteLine("Please enter number in [1, 10]");
                else
                    invalidInput = false;
            }
            return number;
        }
    }
}