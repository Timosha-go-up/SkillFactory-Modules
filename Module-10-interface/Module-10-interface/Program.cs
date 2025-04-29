namespace Module_10_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NewMessenger newMessenger = new NewMessenger();

            ((IWhatsApp)newMessenger).SendMessage("Hello World!");
            ((IViber)newMessenger).SendMessage("Hello World!");

            Console.ReadKey();
        }
    }

        public interface IViber
        {
            public void SendMessage(string message);
        }

        public interface IWhatsApp
        {
            public void SendMessage(string message);
        }

        public class NewMessenger : IWhatsApp, IViber
        {
            void IWhatsApp.SendMessage(string message)
            {
                Console.WriteLine("{0} : {1}", "WhatsApp", message);
            }

            void IViber.SendMessage(string message)
            {
                Console.WriteLine("{0} : {1}", "Viber", message);
            }


        }


    }
}
