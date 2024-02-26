namespace CTBGames.Interfaces.Exceptions;

public class ArgumentOutOfDecisionException : CTBGExceptions
{
    public ArgumentOutOfDecisionException(string? msg = "Decision list do not cotain given index") : base(msg)
    {
    }
}
