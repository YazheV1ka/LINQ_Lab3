using LINQ_Lab3.models;

namespace LINQ_Lab3;

public static class Program
{
    public static void Main(string[] args)
    {
        List<Supplier> suppliers = new List<Supplier>();
        
        Console.WriteLine("Input supplier details (Enter to exit):");
        while (true)
        {
            Console.Write("\nMaterial name(concrete/brick/reinforced concrete plate): ");
            string materialName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(materialName))
                break;
            
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());

            Console.Write("Max Daily Supply: ");
            int maxDailySupply = int.Parse(Console.ReadLine());

            Console.Write("Daily Demand: ");
            int dailyDemand = int.Parse(Console.ReadLine());

            SupplierFactory supplierFactory;
            switch (materialName.ToLower())
            {
                case "concrete":
                    supplierFactory = new ConcreteSupplierFactory();
                    break;
                case "brick":
                    supplierFactory = new BrickSupplierFactory();
                    break;
                case "reinforced concrete plate":
                    supplierFactory = new ReinforcedConcretePlateSupplierFactory();
                    break;
                default:
                    Console.WriteLine("Unknown material! Try again.");
                    continue;
            }

            Supplier supplier = supplierFactory.CreateSupplier();
            suppliers.Add(supplier);


            supplier.Price = price;
            supplier.MaxDailySupply = maxDailySupply;
            supplier.DailyDemand = dailyDemand ;
        }

        int count = 1;
        List<string> name = new List<string>();
        Console.WriteLine("\n\nAll info:");
        foreach (var supplier in suppliers)
        {
            if (name.Contains(supplier.GetType().Name))
            {
                Console.WriteLine($"Material Supplier: {supplier.GetType().Name}{++count}");
            }
            else
            {
                count = 1;
                Console.WriteLine($"Material Supplier: {supplier.GetType().Name}{count}");
            }
            Console.WriteLine($"Price: {supplier.Price}$");
            Console.WriteLine($"Max Daily Supply: {supplier.MaxDailySupply}");
            Console.WriteLine($"Daily Demand: {supplier.DailyDemand}");
            name.Add(supplier.GetType().Name);
        }

        Console.ReadLine();
    }
}