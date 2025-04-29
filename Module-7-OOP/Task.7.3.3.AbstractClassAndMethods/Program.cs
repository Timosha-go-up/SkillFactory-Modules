using System;


namespace Task._7._3._3.AbstractClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            MotherBoard motherBoard = new MotherBoard();
            GraphicCard graphicCard = new GraphicCard();
            processor.Work();
            motherBoard.Work();
            graphicCard.Work();

           
        }

        //Создайте классы для следующих объектов компьютера: процессор(Processor), материнская карта(MotherBoard), видеокарта(GraphicCard).
        //Унаследуйте их от класса ComputerPart.
        //Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.

       abstract class ComputerPart
        {
            public string Name;

            public abstract void Work();
        }

        class Processor : ComputerPart
        {
            public Processor()
            {
                Name = "Processor";
            }
            public override void Work()
            {
                Console.WriteLine("Object:" + Name);
            }
        }

        class GraphicCard : ComputerPart
        {
            public GraphicCard()
            {
                Name = "GraphicCard";
            }
            public override void Work()
            {
                Console.WriteLine("Object:" + Name);
            }
        }

        class MotherBoard : ComputerPart
        {
            public MotherBoard()
            {
                Name = "MotherBoard";
            }
            public override void Work()
            {
                Console.WriteLine("Object:" + Name);
            }
        }


    }
}
