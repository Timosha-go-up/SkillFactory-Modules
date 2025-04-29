namespace Task_10_4_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            IMessenger<IPhone> viberInIphone = new Viber<IPhone>();

            viberInPhone.DeviceInfo();
            viberInIphone.DeviceInfo();

            Console.Read();
        }

        public interface IMessenger<out T>
        {
            T DeviceInfo();
        }

        public class Phone { }
         
        public class IPhone : Phone { }

        public class Viber<T> : IMessenger<T> where T : Phone, new()
        {
            public T DeviceInfo()
            {
                T device = new T();
                Console.WriteLine(device);
                return new T();
            }
        }



    }
}
