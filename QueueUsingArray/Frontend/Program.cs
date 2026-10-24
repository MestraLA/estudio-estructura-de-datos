using Backend;
using System.ComponentModel.Design;

var queue = new Queue<string>();

var option = string.Empty;
do
{
    try
    {
        option = Menu();
        switch (option)
        {
            case "1":
                Console.Write("Enter item to queue: ");
                queue.Enqueue(Console.ReadLine()!);
                break;
            case "2":
                Console.WriteLine($"Dequeue item {queue.Dequeue()}");
                break;
            case "3":
                Console.WriteLine($"peek item {queue.Peek()}");
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (option != "0");
{
    throw new NotImplementedException();
}

string Menu()
{
    Console.WriteLine("1. Queue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. peek");
    Console.WriteLine("0. exit");
    Console.WriteLine("Enter your choice: ");
    return Console.ReadLine()!;
}