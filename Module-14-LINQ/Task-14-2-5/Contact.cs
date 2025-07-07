namespace Task_14_2_5
{
    internal class Contact(string name, string lastName, long phoneNumber, String email)
    {
        public String Name { get; } = name;
        public String LastName { get; } = lastName;
        public long PhoneNumber { get; } = phoneNumber;
        public String Email { get; } = email;
    }
}