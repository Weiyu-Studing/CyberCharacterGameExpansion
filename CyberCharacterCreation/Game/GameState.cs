namespace CyberCharacterCreation.Game;

public class GameState
{
    private static readonly Lazy<GameState> _instance = new(() => new GameState());
    private GameState()
    {

    }


    public static GameState Instance => _instance.Value;

    public DateTime NeoCityStartTime { get; } = DateTime.Now;

    public int ThreatLevel { get; set; } = 1;
}

