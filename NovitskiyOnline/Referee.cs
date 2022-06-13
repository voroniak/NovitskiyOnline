using System;

namespace NovitskiyOnline
{
    public class Referee
    {
        private string name;
        public Referee(string name)
        {
            this.name = name;
        }
        public void Whistle()
        {
            Console.WriteLine($"Арбітр {name} свистить");
        }
    }
}
