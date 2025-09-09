using System.Threading.Tasks;

namespace async
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("1. Включи чайник...");

            Task boilTask = BoilWaterAsync();
            Task sliceTask = SliceLemonAsync();

            await Task.WhenAll(boilTask, sliceTask);
            Console.WriteLine("3. Завариваем чай!");
        }
        
        static async Task BoilWaterAsync()
        {
            Console.WriteLine("2. Кипятим воду (ждём 3 секунды)...");
            await Task.Delay(3000);
            Console.WriteLine("... Вода закипела");
        }
        
        static async Task SliceLemonAsync()
        {
            Console.WriteLine("3. Режем лимон (ждём 2 секунды)...");
            await Task.Delay(2000);
            Console.WriteLine("...лимон нарезан");
        }
    }
}
