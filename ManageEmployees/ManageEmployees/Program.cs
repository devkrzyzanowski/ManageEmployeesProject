using Company.Finances.Employees;
using Company.Finances.Employees.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmployees {
    class Program {
        static void Main(string[] args) {
            Employee e = new Employee("Michal", "Krzyzanowski", 110, 10, 50);
            e.AddOperation(new Operation("za nic", "dodatek", 20));
            e.SetContractType(ContractType.FullTime);
            Console.WriteLine("{0}", e.GetFirstName());
            e.PrintEmployeeOperationsList();
            Console.WriteLine("Basic salay: {0}", e.GetSalary().GetBasic());
            e.GetSalary().SetBasic(500); //problem
            Console.WriteLine("Basic salay: {0}", e.GetSalary().GetBasic());

            Console.WriteLine("{0}", e.GetContractTypeAsString());
            e.SetContractType(ContractType.Contract);
            Console.WriteLine("{0}", e.GetContractTypeAsString());
            Console.ReadKey();
        }
    }
}
