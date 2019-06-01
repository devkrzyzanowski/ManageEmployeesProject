using Company.Finances.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Finances.Employees {
    class Employees {
        public List<Employee> EmployeeList = new List<Employee>();


        public void addToEmployeeList(Employee e) {
            if (!EmployeeList.Contains(e)) {
                EmployeeList.Add(e);
            }
        }

        public void CreateAndAddEmployeeToList(string firstName, string surname) {
            Employee e = new Employee(firstName, surname);
            addToEmployeeList(e);
        }

        public void RemoveEmployee(Employee e) {
            if (EmployeeList.Contains(e)) {
                EmployeeList.Remove(e);
            }
        }


        public List<Employee> GetEmployeeList() {
            return EmployeeList;
        }

        public Employee GetSpecificEmployee(string name, string surname) {
            foreach(Employee e in EmployeeList) {
                if (e.GetFirstName() == name && e.GetSurName() == surname) {
                    return e;
                }
            }
            return null;
        }

    }
}
