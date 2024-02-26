using CTBGames.Interfaces.Action;

namespace CTBGames.Interfaces.Rule;

public interface ICTBGDecision
{
    IReadOnlyList<ICTBGAction> Actions { get; }
    void Initiate();
}
