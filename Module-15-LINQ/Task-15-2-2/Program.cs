namespace Task_15_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
            new() { Name = "Андрей",  Phone = 79994500508 },
            new() { Name = "Сергей",  Phone = 799990455 },
            new() { Name = "Иван",    Phone = 79999675334 },
            new() { Name = "Игорь",   Phone = 8884994 },
            new() { Name = "Анна",    Phone = 665565656 },
            new() { Name = "Василий", Phone = 3434 }
            };

            var invalidContacts =
            // пробегаемся по контактам
            (from contact in contacts

            // сохраняем в промежуточную переменную строку номера телефона 
            let phoneString = contact.Phone.ToString() 

            // выполняем выборку по условиям
            where !phoneString.StartsWith('7') || phoneString.Length != 11 

            // добавляем объект в выборку
           select contact) 
            // считаем количество объектов в выборке
           .Count();
           
            Console.WriteLine(invalidContacts);
        }
    }
}
