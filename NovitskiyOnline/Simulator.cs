using System;

namespace NovitskiyOnline
{
    public static class Simulator
    {
        public static void Move(Position position, Ball ball = null, params FieldPlayer[] fieldPlayers)
        {
            if (Position.Center == position && ball != null)
            {
                Console.WriteLine("М'яч в центрі");
            }
            else if (Position.PenaltyArea == position)
            {
                string names = string.Empty;
                if(ball != null)
                {
                    names += "М'яч ";
                }
                foreach (var player in fieldPlayers)
                {

                    names += player.Name;
                    names += ", ";
                }
                Console.WriteLine($"{names} у штрафній");
            }
        }

        public static void Move(Position position,  params FieldPlayer[] fieldPlayers)
        {
            Move(position, null, fieldPlayers);
        }
    }
}
