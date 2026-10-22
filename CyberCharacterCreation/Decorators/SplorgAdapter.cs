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
        get => _legacySplorg.Name;
        set => _legacySplorg.Name = value;
    }
    public override string Race => "Splorg";
    public override string CharacterClass => "Unassigned Operative";

    public override int Health => (int)(_legacySplorg.BubbleMatterRemaining * 100);
    public override int Defense => _legacySplorg.BubbleDurability;
    public override int Speed => _legacySplorg.Speed;
    public override int Strength => _legacySplorg.Luck;
    public override int Intellect => _legacySplorg.Smarts;
    public override int Agility => _legacySplorg.Finesse;



    public override void Act() => throw new NotImplementedException();
    public override void Speak() => throw new NotImplementedException();
    public override void PrintDetails() => throw new NotImplementedException();
}

