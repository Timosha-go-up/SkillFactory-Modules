namespace Task_10_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public interface IWriter
        {
            void Write();
        }

        public interface IReader
        {
            void Read();
        }

        public interface IMailer
        {
            void SendEmail();
        }
        class FileManager : IWriter, IReader, IMailer
        {
            public void Read()
            {
                throw new NotImplementedException();
            }

            public void SendEmail()
            {
                throw new NotImplementedException();
            }

            public void Write()
            {
                throw new NotImplementedException();
            }
        }
    }
}
