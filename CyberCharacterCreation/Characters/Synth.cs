namespace CyberCharacterCreation.Characters;

public class Synth : RaceCharacter
{
    public Synth(string name) : base(name, health: 120, defense: 13, speed: 9, strength: 13, intellect: 10, agility: 8)
    {
    }

    public override string Race => "Synth";

    public override void Act()
    {
        Console.WriteLine($"{Name} activates cyber‑joints, mechanical movements precise and cold.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name}: \"I AM THE NEW!\"");
    }
}

