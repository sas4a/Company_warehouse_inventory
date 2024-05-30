using System.Text;

namespace Inventory;

public class Employee
{
    public string Name { get; }
    public string Position { get; }
    private readonly List<Inventory> _inventoryItems;

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
        _inventoryItems = new List<Inventory>();
    }
    public void AddInventory(Inventory item)
    {
        _inventoryItems.Add(item);
    }
    public string GetInventoryDescription()
    {
        StringBuilder description = new StringBuilder();
        foreach (var item in _inventoryItems)
        {
            description.AppendLine(item.GetDescription());
        }
        return description.ToString();
    }
}