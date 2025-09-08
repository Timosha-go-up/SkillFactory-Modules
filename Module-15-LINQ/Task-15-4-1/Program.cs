namespace Task_15_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new() {Id = 1, Name = "Программирование"},
                new() {Id = 2, Name = "Продажи"}
            };

            var employees = new List<Employee>()
            {
                new() { DepartmentId = 1, Name = "Инна", Id = 1},
                new() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                new() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var employeeAndDep = from employee in employees
            join dep in departments on employee.DepartmentId equals dep.Id //  соединяем коллекции по общему ключу
            select new // выборка в новую сущность
            {
            EmployeeName = employee.Name,
            DepartmentName = dep.Name
            };

            foreach (var item in employeeAndDep)
            Console.WriteLine(item.EmployeeName + ", отдел: " + item.DepartmentName);
        }
    }
}
