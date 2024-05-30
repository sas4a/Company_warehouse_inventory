namespace Inventory;

public class Warehouse
{
    private List<Inventory> _items = new List<Inventory>();
    private int _inventoryCounter = 1; // I made the inventory number in the warehouse separate so
                                       // as to be independent from the array '_items'
    public void AddItem(Inventory item)
    {
        item.AddInventoryNumber(_inventoryCounter);
        _items.Add(item);
        _inventoryCounter++;
    }
    public void DeleteItem(Inventory item)
    {
        _items.Remove(item);
    }
    public void InventoryCheck()
    {
        Console.WriteLine($"INVENTORY AVAILABILITY LIST IN THE WAREHOUSE: {DateTime.Now}");
        foreach (var i in _items)
        {
            Console.WriteLine(i.GetDescription());
        }
        Console.WriteLine();
    }
    public void WriteInventoryResultToFile()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "Remaining stock.txt");

        using (StreamWriter writer = new StreamWriter(filePath,append:true))
        {
            writer.WriteLine($"INVENTORY AVAILABILITY LIST IN THE WAREHOUSE: {DateTime.Now}");
            foreach (var i in _items)
            {
                string itemDescription = i.GetDescription();
                writer.WriteLine(itemDescription);
            }
        }
    }
}