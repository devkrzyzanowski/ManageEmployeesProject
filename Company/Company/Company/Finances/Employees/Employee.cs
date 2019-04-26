using Company.Finances.Employees.Enumerations;
using Company.Finances.Employees.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Finances.Employees {

        public class Employee : Person {
            private Salary salary;
            private ContractType contractType;
            private float holidayBonus = 1000;
            private List<Operation> operations = new List<Operation>();

            public Employee(string firstName, string lastName, float basic, float bonus, float other) : base(firstName, lastName) {
                this.salary.SetBasic(basic);
                this.salary.SetBonus(bonus);
                this.salary.SetOther(other);
                this.contractType = ContractType.FullTime;
            }

            public Employee(string firstName, string lastName) : base(firstName, lastName) {
                this.salary.SetBasic(0f);
                this.salary.SetBonus(0f);
                this.salary.SetOther(0f);
                this.contractType = ContractType.FullTime;
            }

            public void PrintEmployeeOperationsList() {
                foreach (Operation o in operations) {
                    Console.WriteLine(
                             "Operation: {0} is a {1} on amount {2}.",
                             o.GetLabel(), o.GetType(), o.GetAmount()
                         );
                }
            }

            public void AddOperation(Operation o) {
                operations.Add(o);
            }

            public void SetContractType(ContractType value) {
                this.contractType = value;
            }

            public void SetHolidayBonus(float value) {
                this.holidayBonus = value;
            }

            public float GetHolidayBonus() {
                return holidayBonus;
            }

            public Salary GetSalary() {
                return salary;
            }

            public ContractType GetContractType() {
                return contractType;
            }

            public string GetContractTypeAsString() {
                switch (contractType) {
                    case ContractType.FullTime:
                        return "Full time";
                    case ContractType.PartTime:
                        return "Part time";
                    case ContractType.Contract:
                        return "Contract";
                    default:
                        return "Undefined"; ;
                }
            }

        }
    }