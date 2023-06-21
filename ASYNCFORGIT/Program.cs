  
class Program
{


    static async Task Main(string[] args)
    {
        var result1 = await LongProcess1();
        Console.WriteLine(result1);
        Console.ReadKey();
    }

    static async Task<string> LongProcess1()
    {
        Console.WriteLine("LongProcess 1 Started");

        await Task.Delay(4000);

        Console.WriteLine("LongProcess 1 Completed");

        return "method 1";
    }

   

    
}
