namespace CTBGames.Interfaces.Play;

public interface ICTBGInstance
{
    void LoadGameData(IReadOnlyDictionary<string, string> data);
    IReadOnlyDictionary<string, string> SaveGameData();
}
