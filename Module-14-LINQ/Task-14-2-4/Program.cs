using System.Runtime.InteropServices;
using Task_14_2_3;

namespace Task_14_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Список студентов
            var students = new List<Student>
            {
             new() {Name = "Андрей",  Age = 23, Languages = ["английский", "немецкий"]},
             new() {Name = "Сергей",  Age = 27, Languages = ["английский", "французский"]},
             new() {Name = "Дмитрий", Age = 29, Languages = ["английский", "испанский"]}
            };

            // Список курсов
            var courses = new List<Course>
            {
             new() {Name = "Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
             new() {Name = "Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };


            var studentsWithCoarses = from stud in students
            where stud.Age < 29 // берем всех студентов младше 29
            where stud.Languages.Contains("английский") // ищем тех, у кого в списке языков есть английский
            let birthYear = DateTime.Now.Year - stud.Age // Вычисляем год рождения
            from coarse in courses
            where coarse.Name.Contains("C#") // теперь выбираем только курс по C#
            select new // выборка в новую сущность
            {
             stud.Name,
             BirthYear = birthYear,
             CoarseName = coarse.Name
            };

            // выведем результат
            foreach (var stud in studentsWithCoarses)
            Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) добавлен курс {stud.CoarseName}");
        }


    }

   
}
