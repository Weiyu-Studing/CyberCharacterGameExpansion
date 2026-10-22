using System.Drawing;

namespace CyberCharacterCreation.Characters;

public class Human : RaceCharacter
{
    public Human(string name, string color) : base(name, color, health: 100, defense: 9, speed: 11, strength: 10, intellect: 12, agility: 11)
    {
    }

    public override string Race => "Human";

    public override void Act()
    {
        Console.WriteLine($"{Name} moves with organic reflexes, checking surroundings.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name}: \"Even in neon chaos, humanity still matters.\"");
    }
}

