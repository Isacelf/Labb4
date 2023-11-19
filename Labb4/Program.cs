namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Em1 = new Employee(101, "Isac", "Male", 27000);
            Employee Em2 = new Employee(102, "Nellie", "Female", 30000);
            Employee Em3 = new Employee(103, "Emil", "Male", 32000);
            Employee Em4 = new Employee(104, "Felix", "Male", 35000);
            Employee Em5 = new Employee(105, "Mira", "Female", 37000);

            Stack<Employee> EmStack = new Stack<Employee>();
            EmStack.Push(Em1);
            EmStack.Push(Em2);
            EmStack.Push(Em3);
            EmStack.Push(Em4);
            EmStack.Push(Em5);

            foreach (Employee em in EmStack)
            {
                em.EmployeeInfo();
                Console.WriteLine($"Items left in stack: {EmStack.Count}");
            }
            Console.WriteLine("---------------------------------------\nRetrive Using Pop Method");
           
            while ( EmStack.Count > 0 )
            {
                Employee EmpPop = EmStack.Pop();
                EmpPop.EmployeeInfo();
                Console.WriteLine($"Items left in stack: {EmStack.Count}");
            }
            Console.WriteLine("---------------------------------------\nRetrive Using Peek Method");
           
            EmStack.Push(Em1);
            EmStack.Push(Em2);
            EmStack.Push(Em3);
            EmStack.Push(Em4);
            EmStack.Push(Em5);

            Employee EmpPeek = EmStack.Peek();
            for (int i = 0; i < 2; i++)
            {
                EmpPeek.EmployeeInfo();
                Console.WriteLine($"Items left in stack: {EmStack.Count}");
            }
            Console.WriteLine("---------------------------------------");

            if (EmStack.Contains(Em3))
            {
                Console.WriteLine("Employee3 is in the stack!");
            }
            else
            {
                Console.WriteLine("Employee3 is not in the stack!");
            }
            Console.WriteLine("---------------------------------------");


            
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(Em1);
            EmpList.Add(Em2);
            EmpList.Add(Em3);
            EmpList.Add(Em4);
            EmpList.Add(Em5);

            if (EmpList.Contains(Em2))
            {
                Console.WriteLine("Employee2 object exsist in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exsist in the list");
            }
            Console.WriteLine("---------------------------------------");

            Employee firstMaleEmployee = EmpList.Find(employee => employee._gender == "Male");
            if (firstMaleEmployee != null)
            {
                Console.WriteLine($"First employee whos gender is male in the list: ");
                firstMaleEmployee.EmployeeInfo();
            }
            else
            {
                Console.WriteLine("No male employees could be found");
            }
            Console.WriteLine("---------------------------------------");

            List<Employee> findAllMaleEmployees = EmpList.FindAll(employee => employee._gender == "Male");
            Console.WriteLine("Male employees: ");

            foreach (Employee male in findAllMaleEmployees)
            {
                male.EmployeeInfo();
            }
        }
    }
}