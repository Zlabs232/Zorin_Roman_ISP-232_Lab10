//class Program
//{
//    static IEnumerable<int> GenerateNumbers()
//    {
//        Console.WriteLine("Начинаем генерацию...");
//        yield return 1;
//        Console.WriteLine("Пауза...");
//        yield return 2;
//        Console.WriteLine("И ещё раз...");
//        yield return 3;
//        Console.WriteLine("Готово!");
//    }

//    static void Main(string[] args)
//    {
//        foreach (int number in GenerateNumbers())
//        {
//            Console.WriteLine($"Получено число: {number}");
//        }
//    }
//}

using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        foreach (var step in WaitCoroutine())
        {
            Console.WriteLine(step);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Готово (корутина)");

        await WaitAsync();
        Console.WriteLine("Готово (асинхронно)");
    }
    static IEnumerable<string> WaitCoroutine()
    {
        yield return "Ждём... 1 секунда";
        yield return "Ждём... 2 секунда";
    }

    static async Task WaitAsync()
    {
        Console.WriteLine("Асинхронное ожидание... 1 секунда");
        await Task.Delay(1000);

        Console.WriteLine("Асинхронное ожидание... 2 секунда");
        await Task.Delay(1000);
    }
}