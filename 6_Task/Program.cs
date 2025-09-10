namespace _6_Task
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Загрузка данных..");
            var students = await LoadStudentsAsync(); // Исправлено: LoadStudentsAync → LoadStudentsAsync

            var teachers = new List<Teacher>
            {
                new Teacher{Name = "Леонтьев Денис Александрович", department = "ИСРПО"},
                new Teacher{Name = "Леонтьев Денис Александрович", department = "3Д_комп_модел"},
                new Teacher{Name = "Леонтьев Денис Александрович", department = "РМП"},
                new Teacher{Name = "Полковников Александр Александрович", department = "РМП"},
                new Teacher{Name = "Токаев Тимур Ильич", department = "Системное программирование"},
                new Teacher{Name = "Катунов Дмитрий Александрович", department = "ТРПО"},
            };

            List<IPerson> people = new List<IPerson>();
            people.AddRange(students);
            people.AddRange(teachers);

            Console.WriteLine("\nВсе люди:");
            Console.WriteLine(new string('-', 40));
            foreach (var person in people)
            {
                person.GetDescription();
            }

            Console.WriteLine("\n" + new string('=', 40));
            Console.WriteLine("linq запросы:");
            Console.WriteLine(new string('=', 40));

            var olderS = students.Where(s => s.Age > 20).ToList();
            Console.WriteLine("\nСтуденты старше 20 лет:");
            foreach (var student in olderS)
            {
                student.GetDescription();
            }

            string targ = "РМП";
            var infT = teachers
                .Where(t => t.department.Equals(targ, StringComparison.OrdinalIgnoreCase)) 
                .ToList();

            Console.WriteLine($"\nПреподаватели кафедры '{targ}':");
            foreach (var teacher in infT)
            {
                teacher.GetDescription();
            }

            Console.WriteLine("\n" + new string('=', 40));
            Console.WriteLine("Сортировка по имени:");
            Console.WriteLine(new string('=', 40));

            var sortedP = people.OrderBy(p => p.Name).ToList();
            foreach (var person in sortedP)
            {
                person.GetDescription();
            }
        }

        static async Task<List<Student>> LoadStudentsAsync() 
        {
            Console.WriteLine("Загрузка данных студентов...");
            await Task.Delay(3000);

            return new List<Student>
            {
                new Student { Name = "Колян Шопкин", Age = 10 },
                new Student { Name = "Диман Лулумбеков", Age = 11 },
                new Student { Name = "Роман Зорин", Age = 12 },
                new Student { Name = "Андрей Яшин", Age = 14 },
                new Student { Name = "Титиёми Лулумбетов", Age = 18 },
                new Student { Name = "Шельма", Age = 18 }
            };
        }

    }
}
