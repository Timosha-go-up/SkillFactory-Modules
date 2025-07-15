namespace Task_15_3_3
{
    internal class Contact
    {
        public Contact(string name, long v2, string email)
        {
            Name = name;
            V2 = v2;
            Email = email;
        }

        public string Name { get; }
        public long V2 { get; }
       
        public string Email { get; set; }
    }
}