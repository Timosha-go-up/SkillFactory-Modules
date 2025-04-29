using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6.Encapsulation._6._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        class User
        {
            private int age;

            private string login;

            private string email;

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Возраст должен быть не меньше 18");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
            public string Login
            {
                get
                {
                    return login;
                }

                set
                {
                    if (login.Length <= 3)
                    {
                        Console.WriteLine("Длина логина меньше 3 символов");
                    }
                    else
                    {
                        login = value;
                    }
                }
            }

            

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    if (!value.Contains('@'))
                    {
                        Console.WriteLine("Неверный формат адреса электронной почты");
                    }
                    else
                    {
                        email = value;
                    }
                }
            }
        }

        //Добавьте в класс User из примера выше свойства для логина и почты:
        //Поле логина должно быть не менее 3 символов длиной.
        //Поле почты должно содержать знак @.
    }
}
