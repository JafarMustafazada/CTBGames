namespace CTBGames.Interfaces.Rule;

public interface ICTBGRules
{
    public ICTBGDecisionList QuickDecisions { get; set; }
    public ICTBGDecisionList CurrentDecisions { get; set; }
}
