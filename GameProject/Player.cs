using System;


namespace GameProject
{
    public class Player
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
        public virtual int GuessNumber()
        {
            Random rd = new Random();
            return rd.Next(1, 10);
        }
    }
}