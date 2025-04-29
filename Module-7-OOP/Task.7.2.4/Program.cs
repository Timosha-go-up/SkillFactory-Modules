﻿using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Task._7._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        class BaseClass
        {
            
            public virtual int Counter
            {
                get;
                set;
            }
        }

        class DerivedClass : BaseClass
        {

               private int counter;

            public override int Counter
            {
                
                get
                {
                    return counter;
                }

                set 
                {
                    if (value >= 0) counter = value;
                } 
            }


        }
    }
}
