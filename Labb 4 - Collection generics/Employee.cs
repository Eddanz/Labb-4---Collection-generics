using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Collection_generics
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string gender, double salary) 
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name} - Gender: {Gender} - Salary: {Salary}";
        }

        public static void RunStack()
        {
            Employee Em1 = new Employee(101, "Eddie", "Male", 30000);
            Employee Em2 = new Employee(102, "Sara", "Female", 32000);
            Employee Em3 = new Employee(103, "Felix", "Male", 35000);
            Employee Em4 = new Employee(104, "Cecilia", "Female", 28000);
            Employee Em5 = new Employee(105, "Vincent", "Male", 24000);

            Stack<Employee> emStack = new Stack<Employee>();

            emStack.Push(Em1);
            emStack.Push(Em2);
            emStack.Push(Em3);
            emStack.Push(Em4);
            emStack.Push(Em5);

            foreach (Employee e in emStack)
            {
                Console.WriteLine($"Employee's left in the Stack: {emStack.Count}" +
                    $"\n{e}\n");
            }
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Retrive using Pop Method\n");
            while (emStack.Count > 0)
            {
                Employee emPop = emStack.Pop();
                Console.WriteLine($"{emPop}" +
                    $"\nEmployee's left in the Stack: {emStack.Count}\n");
            }
            Console.WriteLine("----------------------------------------------------------");

            emStack.Push(Em1);
            emStack.Push(Em2);
            emStack.Push(Em3);
            emStack.Push(Em4);
            emStack.Push(Em5);

            Console.WriteLine("Retrive using Peek Method\n");
            Employee emPeek = emStack.Peek();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{emPeek}" +
                    $"\nEmployee's left in the Stack: {emStack.Count}\n");
            }
            Console.WriteLine("----------------------------------------------------------");

            if (emStack.Contains(Em3))
            {
                Console.WriteLine("Employee 3 is in the Stack!\n");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in the Stack...\n");
            }
            Console.WriteLine("----------------------------------------------------------");
        }

        public static void RunList()
        {
            Employee Em1 = new Employee(101, "Eddie", "Male", 30000);
            Employee Em2 = new Employee(102, "Sara", "Female", 32000);
            Employee Em3 = new Employee(103, "Felix", "Male", 35000);
            Employee Em4 = new Employee(104, "Cecilia", "Female", 28000);
            Employee Em5 = new Employee(105, "Vincent", "Male", 24000);

            List<Employee> emList = new List<Employee>();

            emList.Add(Em1);
            emList.Add(Em2);
            emList.Add(Em3);
            emList.Add(Em4);
            emList.Add(Em5);

            if (emList.Contains(Em2))
            {
                Console.WriteLine("Employee 2 object exist in the list\n");
            }
            else
            {
                Console.WriteLine("Emplyee 2 object does not exist in the list\n");
            }
            Console.WriteLine("----------------------------------------------------------");

            Employee firstMale = emList.Find(e => e.Gender == "Male");
            if (firstMale != null)
            {
                Console.WriteLine($"First employee whos gender is male: \n\n{firstMale}\n");
            }
            Console.WriteLine("----------------------------------------------------------");

            List<Employee> allMaleEmployees = emList.FindAll(e => e.Gender == "Male");
            Console.WriteLine("All male employees:\n");
            foreach (Employee e in allMaleEmployees)
            {
                Console.WriteLine($"{e}\n");
            }
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
