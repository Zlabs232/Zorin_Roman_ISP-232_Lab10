namespace _5_Task
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Ждём данные... Осталось 10 секунд..");

            int result = await GetDataAsync();

            Console.WriteLine("Данные получены!");
            Console.WriteLine($"Результат: {result}");
        }

        static async Task<int> GetDataAsync()
        {
            await Task.Delay(10000);

            return 42; 
        }
    }
}