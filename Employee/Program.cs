namespace EmployeeProject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ////Employee.dept = "HR";
            //Employee.Department();
            //Employee employee = new Employee();
            //employee.GetDetails();
            //employee.DisplayDetails();
            
            Employee employee1 = new Employee();
            employee1.GetDetails();
            employee1.DisplayDetails();

            Employee employee2 = new Employee(name:"Ajay");
            employee2.DisplayDetails();

            Employee employee3 = new Employee(id:100, name:"Lalit");

            employee3.DisplayDetails();
            Employee employee4 = new Employee(employee1);
        }
    }
}