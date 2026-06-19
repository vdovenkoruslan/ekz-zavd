using System;

public class Product
{
    protected static int totalProductsCreated = 0;
    
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
        totalProductsCreated++;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Продукт: {Name}");
        Console.WriteLine($"Загальна кількість створених продуктів: {totalProductsCreated}");
    }
}

public class ElectronicProduct : Product
{
    public int WarrantyPeriod { get; set; }

    public ElectronicProduct(string name, int warrantyPeriod) : base(name)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Гарантійний термін: {WarrantyPeriod} місяців");
    }
}

public class ClothingProduct : Product
{
    public string Size { get; set; }

    public ClothingProduct(string name, string size) : base(name)
    {
        Size = size;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Розмір: {Size}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product phone = new ElectronicProduct("Смартфон", 12);
        phone.DisplayInfo();
        Console.WriteLine(new string('-', 20));

        Product tshirt = new ClothingProduct("Футболка", "L");
        tshirt.DisplayInfo();
        Console.WriteLine(new string('-', 20));

        Product laptop = new ElectronicProduct("Ноутбук", 24);
        laptop.DisplayInfo();
    }
}
