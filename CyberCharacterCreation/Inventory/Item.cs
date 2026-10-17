namespace CyberCharacterCreation.Inventory;

public class Item
{
    public string Name { get; }
    public string Desc { get; }

    public Item(string name, string desc)
    {
        Name = name;
        Desc = desc;
    }

    public override string ToString() => $"{Name} — {Desc}";
}

