using CyberCharacterCreation.Characters;
using CyberCharacterCreation.Inventory;

namespace CyberCharacterCreation.Decorators;

public abstract class CharacterDecorator : Character
{
    protected readonly Character WrappedCharacter;

    protected CharacterDecorator(Character wrappedCharacter)
    {
        WrappedCharacter = wrappedCharacter;
    }

    public override IInventoryRepository Inventory => WrappedCharacter.Inventory;

    public override string Name
    {
        get => WrappedCharacter.Name;
        set => WrappedCharacter.Name = value;
    }
    public override string Race => WrappedCharacter.Race;
    public override string CharacterClass => WrappedCharacter.CharacterClass;

    public override int Health => WrappedCharacter.Health;
    public override int Defense => WrappedCharacter.Defense;
    public override int Speed => WrappedCharacter.Speed;
    public override int Strength => WrappedCharacter.Strength;
    public override int Intellect => WrappedCharacter.Intellect;
    public override int Agility => WrappedCharacter.Agility;
}

