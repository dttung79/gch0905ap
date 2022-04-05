using System;


namespace GameProject
{
    public abstract class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Player()
        {
            Name = "Player";
            Number = 0;
        }
        public Player(string name)
        {
            Name = name;
            Number = 0;
        }
        public virtual int GenNumber()
        {
            Random rd = new Random();
            return rd.Next(1, 10);
        }
        public abstract int GuessNumber();  // abstract method
    }
}