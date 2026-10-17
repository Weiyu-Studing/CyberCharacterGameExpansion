using CyberCharacterCreation.Characters;

namespace CyberCharacterCreation.Decorators;

public class MercenaryDecorator : CharacterDecorator
{
    public MercenaryDecorator(Character wrappedCharacter) : base(wrappedCharacter)
    {
    }

    public override string CharacterClass => "Mercenary";
    public override int Health => WrappedCharacter.Health + 18;
    public override int Defense => WrappedCharacter.Defense + 5;
    public override int Strength => WrappedCharacter.Strength + 6;

    public override void Act()
    {
        WrappedCharacter.Act();
        Console.WriteLine($"{Name} draws a heavy firearm and takes combat stance.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name}: \"Creds first, questions later.\"");
    }
}
