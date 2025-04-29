namespace Task_10_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker2 worker = new Worker2();

            ((IWorker2)worker).Build();
        }

        public interface IWriter
        {
            void Write();
        }


        public class Writer : IWriter
        {
            void IWriter.Write()
            {
                
            }
        }

        public interface IWorker
        {
            public void Build();
        }


        public class Worker : IWorker
        {
            public void Build()
            {
              
            }
        }


        public interface IWorker2
        {
            public void Build();
        }


        public class Worker2 : IWorker2
        {
            void IWorker2.Build()
            {
              
            }
        }


    }   
    
}
