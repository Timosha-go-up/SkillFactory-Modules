using System;


namespace Task._7._2._14.TheIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }

            public int this[int Index]
            {
                get
                {
                     return array[Index];
                }

                private set
                {
                    array[Index] = value;

                }

            }

        }

    }
   
}
