using CyberCharacterCreation.Characters;
using Artifact_Legacy_Code;
using CyberCharacterCreation.Decorators;


namespace CyberCharacterCreation.Factories;

public static class CharacterFactory
{
    public static Character CreateCharacter(string race, string name)
    {
        return race.Trim().ToLower() switch
        {
            "human" => new Human(name),
            "synth" => new Synth(name),
            "splorg" => new SplorgAdapter(new Splorg(name, "Blue")),
            _ => throw new ArgumentException("Unknown race type")
        };
    }
}
