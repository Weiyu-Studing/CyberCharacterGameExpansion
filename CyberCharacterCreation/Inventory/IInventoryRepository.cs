namespace CyberCharacterCreation.Inventory;

public interface IInventoryRepository
{
    void Add(Item item);
    bool Remove(string name);
    Item? Find(string name);
    IReadOnlyList<Item> GetAll();
}