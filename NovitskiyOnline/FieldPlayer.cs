using System;

namespace NovitskiyOnline
{
    public class FieldPlayer : MatchParticipant
    {
      
        private string name;
        private int violationsNumber = 0;
        public FieldPlayer(string name)
        {
            this.name = name;
            Role = "Гравець";
        }

        public string Name
        {
            get { return name; }
        }
        public void Pass(FieldPlayer fieldPlayer)
        {
            Console.WriteLine($"{name} віддає пас {fieldPlayer.name}");
        }

        public void KickOnGoal()
        {
            Console.WriteLine($"{Role} {name} б'є по воротах");
        }

        public void PickBooking()
        {
            if(violationsNumber == 0)
            {
                Console.WriteLine($"{Role} {name} отримує жовту карточку");
            }
            else if( violationsNumber >= 1)
            {
                Console.WriteLine($"{Role} {name} отримує червону карточку");
            }
            violationsNumber++;
        }


        public override void CatchBall()
        {
            Console.WriteLine($"{Role} {name} бере м'яч в руки і порушує правила на жаль");

        }
    }
}
