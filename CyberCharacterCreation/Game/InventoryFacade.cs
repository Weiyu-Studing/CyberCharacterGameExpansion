using CyberCharacterCreation.Inventory;

namespace CyberCharacterCreation.Game;

public class InventoryFacade
{
    private readonly IInventoryRepository _repo;
    public InventoryFacade(IInventoryRepository repo) => _repo = repo;

    public void QuickAdd(string itemName, string desc)
    {
        _repo.Add(new Item(itemName, desc));
    }

    public void PrintAllItems()
    {
        var list = _repo.GetAll();
        if (!list.Any())
        {
            Console.WriteLine("(Inventory empty)");
            return;
        }
        foreach (var it in list) Console.WriteLine($"- {it}");
    }

    public bool QuickRemove(string name) => _repo.Remove(name);
    public Item? QuickSearch(string name) => _repo.Find(name);
}
