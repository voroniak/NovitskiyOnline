namespace NovitskiyOnline
{
    public abstract class MatchParticipant : IBallCatcher
    {
        public string Role { get; set; }
        public abstract void CatchBall();
    }
}
