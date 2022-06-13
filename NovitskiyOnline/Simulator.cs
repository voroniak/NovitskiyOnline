using System;

namespace NovitskiyOnline
{
    public static class Simulator
    {
        public static void Move(Position position, Ball ball, params FieldPlayer[] fieldPlayers)
        {
            if (Position.Center == position)
            {
                Console.WriteLine("М'яч в центрі");
            }
            else if (Position.PenaltyArea == position)
            {
                string names = string.Empty;
                foreach (var player in fieldPlayers)
                {

                    names += player.Name;
                    names += ", ";
                }
                Console.WriteLine($"м'яч {names} у штрафній");
            }
        }
    }
}
