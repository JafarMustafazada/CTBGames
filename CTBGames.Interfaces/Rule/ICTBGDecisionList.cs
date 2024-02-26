using CTBGames.Interfaces.Exceptions;

namespace CTBGames.Interfaces.Rule;

public interface ICTBGDecisionList
{
    IReadOnlyList<ICTBGDecision> Decisions { get; }
    void Initiate(int index)
    {
        if (index < 0 && index >= this.Decisions.Count) throw new ArgumentOutOfDecisionException();
        this.Decisions[index].Initiate();
    }
}
