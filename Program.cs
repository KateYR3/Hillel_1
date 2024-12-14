using System;

class Program
{
    static void Main()
    {
        string? customerName;
        string? productName;
        double productPrice;
        string? customerAddress;
        int customerAdressNum;

        Console.Write("Client name: ");
        customerName = Console.ReadLine();
        Console.Write("Product name: ");
        productName = Console.ReadLine();
        Console.Write("Price: ");
        productPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Client address: ");
        customerAddress = Console.ReadLine();
        Console.Write("Num: ");
        customerAdressNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        string ordernumber = "Order No 1";
        Console.WriteLine(ordernumber);

        Console.WriteLine($"Client: {customerName}.");
        Console.WriteLine($"Product: {productName}, price {productPrice} EUR.");
        Console.WriteLine($"Address: {customerAddress}, {customerAdressNum}.");
       
        Console.WriteLine();

        Console.Write("Client name: ");
        customerName = Console.ReadLine();
        Console.Write("Product name: ");
        productName = Console.ReadLine();
        Console.Write("Price: ");
        productPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Client adress: ");
        customerAddress = Console.ReadLine();
        Console.Write("Num: ");
        customerAdressNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        var ordernumber2 = "Order No 2";
        Console.WriteLine(ordernumber2);

        Console.WriteLine($"Client: {customerName}.");
        Console.WriteLine($"Product: {productName}, price {productPrice} EUR.");
        Console.WriteLine($"Address: {customerAddress}, {customerAdressNum}.");

        Console.WriteLine();

        Console.Write("Client name: ");
        customerName = Console.ReadLine();
        Console.Write("Product name: ");
        productName = Console.ReadLine();
        Console.Write("Price: ");
        productPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Client adress: ");
        customerAddress = Console.ReadLine();
        Console.Write("Num: ");
        customerAdressNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        var ordernumber3 = "Order No 3";
        Console.WriteLine(ordernumber3);

        Console.WriteLine($"Client: {customerName}. ");
        Console.WriteLine($"Product: {productName}, price {productPrice} EUR.");
        Console.WriteLine($"Address: {customerAddress}, {customerAdressNum}.");
       
        Console.WriteLine();
    }
}