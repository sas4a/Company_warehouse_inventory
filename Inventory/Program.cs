using System;
using System.Linq;
using System.Collections;
using System.IO;

namespace Inventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //This functionality allows you to do basic inventory operations and also has the ability to print a warehouse list
            
            // 1. Let's create a company
            var gameDev = new Company();

            // 2. Creating Inventory Items
            var chair = new Furniture("Chair", "office chair on wheels", "black");
            var table = new Furniture("Table", "computer desk with drawer", "brown");
            var printer = new Printer("Printer", "Canon", "NVD13");
            var computer = new Computer("Computer", "Mac", "Pro", "16Gb");

            // 3. Let's create a warehouse for our company
            var warehouse = new Warehouse();
            gameDev.AddWarehouseInCompany(warehouse);

            // 4. We will fill the warehouse with company property
            warehouse.AddItem(chair);
            warehouse.AddItem(table);
            warehouse.AddItem(printer);
            warehouse.AddItem(computer);
            
            // 5. Let's see what we have in stock
            warehouse.InventoryCheck();
            
            // 6. Сreate employees
            var employee1 = new Employee("Mike", "Manager");
            var employee2 = new Employee("Kate", "Developer");

            // 7. Adding employees to the company
            gameDev.AddEmployee(employee1);
            gameDev.AddEmployee(employee2);
            
            // 8. Give equipment to employees
            gameDev.GiveInventoryToEmployee(employee1,table);
            gameDev.GiveInventoryToEmployee(employee2,computer);

            // 8. We take inventory 
            gameDev.InventoryCheck();
            
            // 9. Checking what's left in stock 
            warehouse.InventoryCheck();
            
            // 10. We can write the inventory result to a file and, for example, print it
            warehouse.WriteInventoryResultToFile();
        }
    } 
}