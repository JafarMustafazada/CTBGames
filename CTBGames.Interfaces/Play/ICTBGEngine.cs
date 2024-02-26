using CTBGames.Interfaces.Rule;

namespace CTBGames.Interfaces.Play;

public interface ICTBGEngine
{
    ICTBGInstance LoadGameRules(ICTBGRules rules);
}
