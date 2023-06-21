  
class Program
{


    static async Task Main(string[] args)
    {
        var result1 = await LongProcess1();
        var result2 = await LongProcess2();
        var result4 = await LongProcess4();
        var result5 = await LongProcess5();
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.ReadKey();
        
    }

    static async Task<string> LongProcess1()
    {
        Console.WriteLine("LongProcess 1 Started");

        await Task.Delay(4000);

        Console.WriteLine("LongProcess 1 Completed");

        return "method 1";
    }
    static async Task<int> LongProcess2()
    {
        Console.WriteLine("LongProcess 2 Started");

        await Task.Delay(4000);

        Console.WriteLine("LongProcess 2 Completed");

        return 2;
    }
    static async Task<string> LongProcess4()
    {
        Console.WriteLine("LongProcess 4 Started");

        await Task.Delay(4000);

        Console.WriteLine("LongProcess 4 Completed");

        return "method 4";
    }

    static async Task<string> LongProcess5()
    {
        Console.WriteLine("LongProcess 5 Started");

        await Task.Delay(4000);

        Console.WriteLine("LongProcess 5 Completed");

        return "method 4";
    }




}
