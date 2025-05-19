namespace Task_13_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var  listcontact = new List<Contact>();

          Contact contact1 = new("Ego",9805,"1@2");
          Contact contact2 = new("Ego", 98056, "1@2");
            Contact contact3 = new("Ego", 9605, "1@2");

            AddUnique(contact1,listcontact);
            AddUnique(contact2,listcontact);
            AddUnique(contact1,listcontact);
            AddUnique(contact1, listcontact);
            AddUnique(contact2,listcontact);
            AddUnique(contact3,listcontact);
        }


       public static void AddUnique( Contact contact, List<Contact> phoneBook)
       {           
            if (phoneBook.Count < 1)
            {
                phoneBook.Add(contact);

                Console.WriteLine("first contact succsesfully added");
            }
            else
            {  
                bool exsist = false;
                
                foreach (var item in phoneBook)
                {
                    if (contact.PhoneNumber == item.PhoneNumber)
                    {
                         Console.WriteLine("that contact already excist");exsist = true; break;
                    }                   
                }
                if (!exsist) { phoneBook.Add(contact); Console.WriteLine("contact succsesfully added"); }    
            }           
       }
    }

   
}
