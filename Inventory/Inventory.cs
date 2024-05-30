namespace Inventory;

public abstract class Inventory
{
    public string Name{ get; }
    public string Description{ get; }

    private int _inventoryNumber;


    protected Inventory(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public virtual string GetDescription()
    {
        string description = $"Item: {Name}, Inventory number: {_inventoryNumber}";
        return description;
    }

    public void AddInventoryNumber(int number)
    {
        this._inventoryNumber = number;
    }
    public int GetInventoryNumber()
    {
        return _inventoryNumber;
    }
}