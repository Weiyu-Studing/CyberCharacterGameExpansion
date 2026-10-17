namespace CyberCharacterCreation.Inventory;

public class InventoryRepository : IInventoryRepository
{
    private readonly List<Item> _items = new();

    public void Add(Item item) => _items.Add(item);

    public bool Remove(string name)
    {
        var i = Find(name);
        return i != null && _items.Remove(i);
    }

    public Item? Find(string name)
    {
        return _items.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public IReadOnlyList<Item> GetAll() => _items.AsReadOnly();
}