using System;

namespace Test_AP
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            while (true)
            {
                Console.WriteLine("---------------Menu---------------");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please enter your choice: ");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Add product records");
                        controller.AddProduct();
                        break;
                    case 2:
                        Console.WriteLine("2. Display product records");
                        controller.DisplayProduct();
                        break;
                    case 3:
                        Console.WriteLine("3. Delete product by Id");
                        controller.DeleteProdcutById();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}