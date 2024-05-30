namespace Inventory;

public class Furniture : Inventory
{
    public string Color{ get; }

    public Furniture(string name, string description,string color) : base(name,description)
    {
        Color = color;
    }

    public override string GetDescription()
    {
        string description = $"Item: {Name}, Description: {Description}, Color: {Color}, " +
                             $"Inventory number: {GetInventoryNumber()}";
        return description;
    }
}