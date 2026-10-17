using CyberCharacterCreation.Characters;

namespace CyberCharacterCreation.Factories;

public static class CharacterFactory
{
    public static Character CreateCharacter(string race, string name)
    {
        return race.Trim().ToLower() switch
        {
            "human" => new Human(name),
            "synth" => new Synth(name),
            _ => throw new ArgumentException("Unknown race type")
        };
    }
}
