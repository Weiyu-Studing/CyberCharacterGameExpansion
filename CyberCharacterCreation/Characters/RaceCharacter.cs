using CyberCharacterCreation.Inventory;

namespace CyberCharacterCreation.Characters;

public abstract class RaceCharacter : Character
{
    public override string Name { get; set; }
    public override string Color { get; set; }
    public override string CharacterClass => "Unassigned Operative";
    public override IInventoryRepository Inventory { get; }

    public override int Health { get; }
    public override int Defense { get; }
    public override int Speed { get; }
    public override int Strength { get; }
    public override int Intellect { get; }
    public override int Agility { get; }

    protected RaceCharacter(string name, string color, int health, int defense, int speed, int strength, int intellect, int agility)
    {
        Name = name;
        Color = color;
        Health = health;
        Defense = defense;
        Speed = speed;
        Strength = strength;
        Intellect = intellect;
        Agility = agility;
        Inventory = new InventoryRepository();
    }
}