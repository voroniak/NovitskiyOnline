using System;

namespace NovitskiyOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FieldPlayer fieldPlayer = new FieldPlayer("fsfsd");
            Simulator.Move(Position.PenaltyArea, fieldPlayer);
        }
    }
}
