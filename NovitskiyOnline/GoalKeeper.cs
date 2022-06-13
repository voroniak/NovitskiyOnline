using System;

namespace NovitskiyOnline
{
    public class GoalKeeper : MatchParticipant
    {
        private string name;
        public GoalKeeper(string name)
        {
            this.name = name;
            Role = "Воротар";
        }

        public string Name
        {
            get { return name; }
        }

        public override void CatchBall()
        {
            Console.WriteLine($"{Role} {name} бере м'яч в руки");
        }

        public void MissBall()
        {
            Console.WriteLine($"ТАККККК!!!!!!");
        }
    }
}
