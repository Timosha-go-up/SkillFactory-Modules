namespace Task_15_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>
            {
                // добавляем контакты
                new("Игорь", 79990000001, "igor@example.com"),
                new("Сергей", 79990000010, "serge@example.com"),
                new("Анатолий", 79990000011, "anatoly@example.com"),
                new("Валерий", 79990000012, "valera@example.com"),
                new("Сергей", 799900000013, "serg@gmail.com"),
                new("Иннокентий", 799900000013, "innokentii@example.com")
            };

            //  в качестве критерия группировки передаем домен адреса электронной почты
            var grouped = phoneBook.GroupBy(c => c.Email.Split("@").Last());

            // обрабатываем получившиеся группы
            foreach (var group in grouped)
            {
                // если ключ содержит example, значит, это фейк
                if (group.Key.Contains("example"))
                {
                    Console.WriteLine("Фейковые адреса: ");

                    foreach (var contact in group)

                    Console.WriteLine(contact.Name + " " + contact.Email);
                }
                else
                {
                    Console.WriteLine("Реальные адреса: ");
                    foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);
                }

                Console.WriteLine();
            }

        }
    }
}
