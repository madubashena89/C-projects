using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() { ID = 230, Name = "Robert", Age = 28, Salary = 30000, Gender = "Male" };
            Employee Emp2 = new Employee() { ID = 304, Name = "Tom", Age = 30, Salary = 40000, Gender = "Male" };
            Employee Emp3 = new Employee() { ID = 405, Name = "Tanya", Age = 23, Salary = 25000, Gender = "Female" };
            Employee Emp4 = new Employee() { ID = 506, Name = "Buddi", Age = 24, Salary = 23000, Gender = "Female" };
            Employee EMp5 = new Employee() { ID = 503, Name = "Bevan", Age = 30, Salary = 35000, Gender = "Male" };


            Dictionary<int, Employee> DictionaryEmployees = new Dictionary<int, Employee>();
            DictionaryEmployees.Add(Emp1.ID, Emp1);
            DictionaryEmployees.Add(Emp2.ID, Emp2);
            DictionaryEmployees.Add(Emp3.ID, Emp3);
            DictionaryEmployees.Add(Emp4.ID, Emp4);
            DictionaryEmployees.Add(EMp5.ID, EMp5);


            Console.WriteLine("ID = {0}, Name = {1}, Age = {2}, salary = {3}, Gender = {4} ", Emp1.ID, Emp1.ID, Emp1.Age, Emp1.Salary, Emp1.Gender);
            Console.WriteLine("ID = {0}, Name = {1}, Age = {2}, salary = {3}, Gender = {4} ", Emp2.ID, Emp2.ID, Emp2.Age, Emp2.Salary, Emp2.Gender);
            Console.WriteLine("ID = {0}, Name = {1}, Age = {2}, salary = {3}, Gender = {4} ", Emp3.ID, Emp3.ID, Emp3.Age, Emp3.Salary, Emp3.Gender);
            Console.WriteLine("ID = {0}, Name = {1}, Age = {2}, salary = {3}, Gender = {4} ", Emp4.ID, Emp4.ID, Emp4.Age, Emp4.Salary, Emp4.Gender);
            Console.WriteLine("ID = {0}, Name = {1}, Age = {2}, salary = {3}, Gender = {4} ", EMp5.ID, EMp5.ID, EMp5.Age, EMp5.Salary, EMp5.Gender);
            Console.ReadLine();


        }

    

    }
}
