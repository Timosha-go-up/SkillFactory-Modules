namespace Task._7._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        class Employee
        {
         public string ?Name; 

         public int Age; 

         public int Salary;
        }

        class ProjectManager : Employee
        {
           public string ?ProjectName;
        }

        class Developer : Employee
        { 
        public string? ProgrammingLanguage;
        }

        //Класс ProjectManager должен содержать строковое поле ProjectName,
        // а класс Developer — строковое поле ProgrammingLanguage.
}
}
