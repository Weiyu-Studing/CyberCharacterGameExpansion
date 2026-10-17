using CyberCharacterCreation.Characters;

namespace CyberCharacterCreation.Decorators;

public class NetRunnerDecorator : CharacterDecorator
{
    public NetRunnerDecorator(Character wrappedCharacter) : base(wrappedCharacter)
    {
    }

    public override string CharacterClass => "NetRunner";
    public override int Intellect => WrappedCharacter.Intellect + 7;
    public override int Defense => WrappedCharacter.Defense - 2;
    public override int Speed => WrappedCharacter.Speed + 2;

    public override void Act()
    {
        WrappedCharacter.Act();
        Console.WriteLine($"{Name} jacks into the net, hacking nearby systems.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name}: \"We ARE INTERNET, WE ARE EVERYTHINGS!\"");
    }
}

