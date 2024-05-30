namespace Inventory;

public class Company
{
    private List<Employee> _employees = new();
    private Warehouse _warehouse;
        
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public void DeleteEmployee(Employee employee)
    {
        _employees.Remove(employee);
    }

    public void AddWarehouseInCompany(Warehouse warehouse)
    {
        _warehouse = warehouse;
    }

    public void GiveInventoryToEmployee(Employee employee, Inventory item)
    {
        employee.AddInventory(item);
        _warehouse.DeleteItem(item);
    }
    public void InventoryCheck()
    {
        Console.WriteLine("LIST OF INVENTORY ISSUED:");
        foreach (var employee in _employees)
        {
            Console.WriteLine($"Employee {employee.Name}, position {employee.Position}, received the following items:");
            Console.WriteLine(employee.GetInventoryDescription());
        }
    }
}