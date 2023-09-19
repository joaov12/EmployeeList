namespace employeelist
{
    class Employee
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public double Salary {get; private set;}

        public Employee(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int GetId(){
            return Id;
        }
        public void increaseSalary(double percentage){
            Salary = (percentage/100) * Salary + Salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2");
        }
    }
}