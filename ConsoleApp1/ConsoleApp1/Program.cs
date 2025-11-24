namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Task dotsTask = Task.Run(() => {
            Console.WriteLine("...");
            throw new InvalidOperationException("Exception!!");
        });

        Task dashesTask = Task.Run(() =>
        {
            Console.WriteLine("---");
        });
        Console.WriteLine("Hello, World!");

        //dashesTask.Wait();

        //Thread.Sleep(1000000000);
        //Task.Delay(10000);

        dotsTask.Wait();

        List<int> numbers = new() { 1, 2, 3, 4, 5 };

        //dotsTask.Dispose();
    }
}
