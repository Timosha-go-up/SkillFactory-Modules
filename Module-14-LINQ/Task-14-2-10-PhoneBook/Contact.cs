namespace Task_14_2_10_PhoneBook
{
    internal class Contact
    {
        public Contact(string v1, string v2, long v3, string v4)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
        }

        public string V1 { get; }
        public string V2 { get; }
        public long V3 { get; }
        public string V4 { get; }
    }
}