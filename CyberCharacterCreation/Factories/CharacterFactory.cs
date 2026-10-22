using CyberCharacterCreation.Characters;
using Artifact_Legacy_Code;
using CyberCharacterCreation.Decorators;


namespace CyberCharacterCreation.Factories;

public static class CharacterFactory
{
    public static Character CreateCharacter(string race, string name, string color)
    {
        return race.Trim().ToLower() switch
        {
            "human" => new Human(name, color),
            "synth" => new Synth(name, color),
            "splorg" => new SplorgAdapter(new Artifact_Legacy_Code.Splorg(name, color)),
            _ => throw new ArgumentException("Unknown race type")
        };
    }
}
