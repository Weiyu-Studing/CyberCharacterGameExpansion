namespace CyberCharacterCreation.Characters;

public abstract class Character
{
    public abstract string Name { get; set; }
    public abstract string Race { get; }
    public abstract string CharacterClass { get; }

    public abstract int Health { get; }
    public abstract int Defense { get; }
    public abstract int Speed { get; }
    public abstract int Strength { get; }
    public abstract int Intellect { get; }
    public abstract int Agility { get; }

    // 

    public abstract void Act();
    public abstract void Speak();

    public virtual void PrintDetails()
    {
        Console.WriteLine("\n==== Cyber Character Info ====");
        Console.WriteLine($"Name: {Name} | Race: {Race} | Class: {CharacterClass}");
        Console.WriteLine($"HP:{Health} Defense:{Defense} Speed:{Speed} Strength:{Strength} Intellect:{Intellect} Agility:{Agility}");
    }
}

