using System;

namespace employeelist{
    class Program{
        static void Main(string[] args){

            List<Employee> list = new List<Employee>();

            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());  

            for(int i = 0; i < n; i++){
                Console.WriteLine("Employee #" + (i+1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("List of employees");
            foreach(Employee employee in list){
            Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if(emp != null){
                Console.Write("Percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
            }else{
                Console.WriteLine("This ID dont exist!");
            }

           Console.WriteLine("List of employees updated");
           foreach(Employee employee in list){
            Console.WriteLine(employee.ToString());
           }
        }
    }
}