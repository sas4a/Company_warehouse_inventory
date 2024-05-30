namespace Inventory;

public class Computer : Inventory
{
    public string Model{ get; }
    public string Memory{ get; }
    public Computer(string name, string description, string model, string memory) : base(name, description)
    {
        Model = model;
        Memory = memory;
    }
    public override string GetDescription()
    {
        string description = $"Item: {Name}, Description: {Description}, Model: {Model}, Memory: {Memory}, " +
                             $"Inventory number: {GetInventoryNumber()}";
        return description;
    }
}