namespace Task_14_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Наш список студентов
            List<Student> students =
            [
                new() { Name = "Андрей", Age = 23, Languages = ["английский", "немецкий"] },
                new() { Name = "Сергей", Age = 27, Languages = ["английский", "французский"] },
                new() { Name = "Дмитрий", Age = 29, Languages = ["английский", "испанский"] },
                new() { Name = "Василий", Age = 24, Languages = ["испанский", "немецкий"] }
            ];

            var youngStudentApplications = from s in students
            where s.Age < 27 // берем тех, кто младше 27
            let birthYear = DateTime.Now.Year - s.Age // Вычисляем год рождения
            select new Application() // создаем анкеты
            {
             Name = s.Name,
             YearOfBirth = birthYear
            };

            //  вывод
            foreach (var studApplication in youngStudentApplications)
            Console.WriteLine(studApplication.Name + ", " + studApplication.YearOfBirth);
        }




    }
}
