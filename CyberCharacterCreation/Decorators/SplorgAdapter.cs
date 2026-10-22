using Artifact_Legacy_Code;
using CyberCharacterCreation.Characters;
using CyberCharacterCreation.Inventory;

namespace CyberCharacterCreation.Decorators;

public class SplorgAdapter : Character
{
    private readonly Splorg _legacySplorg;
    public override IInventoryRepository Inventory { get; }

    public SplorgAdapter(Splorg legacySplorg)
    {
        _legacySplorg = legacySplorg;
        Inventory = new InventoryRepository();
    }

    public override string Name
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public override string Race => throw new NotImplementedException();
    public override string CharacterClass => throw new NotImplementedException();
    public override int Health => throw new NotImplementedException();
    public override int Defense => throw new NotImplementedException();
    public override int Speed => throw new NotImplementedException();
    public override int Strength => throw new NotImplementedException();
    public override int Intellect => throw new NotImplementedException();
    public override int Agility => throw new NotImplementedException();

    public override void Act() => throw new NotImplementedException();
    public override void Speak() => throw new NotImplementedException();
    public override void PrintDetails() => throw new NotImplementedException();
}

