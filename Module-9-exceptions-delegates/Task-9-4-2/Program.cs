﻿namespace Task_9_4_2
{
    internal class Program
    {
        
        public delegate Car HandlerMethod();

        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }

        static void Main(string[] args)
        {
            HandlerMethod handlerLexus = LexusHandler;

            Console.Read();
        }
    }

    class Car { }

    class Lexus : Car { }
}

