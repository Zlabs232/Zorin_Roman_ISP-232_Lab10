namespace _1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new
            {
                Name = "Роман Зорин",
                Age = 18,
                Group = "ISP-232"
            };
            Console.WriteLine("Отдельный студент:");
            Console.WriteLine($"Имя: {student.Name}");
            Console.WriteLine($"Возраст: {student.Age}");
            Console.WriteLine($"Группа: {student.Group}\n");

            var students = new[]
            {
                new { Name = "Диман Горишний", Age = 18, Group = "ISP-232" },
                new { Name = "Андрей Яшин", Age = 18, Group = "ISP-232" },
                new { Name = "Колян Шопкин", Age = 9, Group = "ISP-232" },
                new { Name = "Гриша Катаржин", Age = 19, Group = "ISP-232" },
                new { Name = "Шишанчик Шишанов", Age = 190, Group = "ISP-231" }
            };
            Console.WriteLine("Список студентов:");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("| {0,-15} | {1,-5} | {2,-8} |", "Имя", "Возраст", "Группа");
            Console.WriteLine(new string('-', 40));
            foreach(var st in students)
            {
                Console.WriteLine("| {0,-15} | {1,-7} | {2,-8} |",
                st.Name, st.Age, st.Group);
            }
            Console.WriteLine(new string('-', 40));




        }
    }
}
