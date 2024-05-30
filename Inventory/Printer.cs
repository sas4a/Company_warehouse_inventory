namespace Inventory;

public class Printer : Inventory
{
    public string Model{ get; }
    public Printer(string name, string description,string model) : base(name, description)
    {
        Model = model;
    }
    public override string GetDescription()
    {
        string description = $"Item: {Name}, Description: {Description}, Model: {Model}, " +
                             $"Inventory number: {GetInventoryNumber()}";
        return description;
    }
}