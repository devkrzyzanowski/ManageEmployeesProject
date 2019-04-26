using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Finances.Employees {

        public class Person {
            private string firstName;
            private string surName;

            public Person(string firstName, string surName) {
                this.firstName = firstName;
                this.surName = surName;
            }

            public void PrintData() {
                Console.WriteLine(
                            "Person: first name: {0}, sur name: {1}",
                            firstName, surName
                        );
            }

            public void SetFirstName(string firstName) {
                this.firstName = firstName;
            }

            public void SetSurName(string surName) {
                this.surName = surName;
            }

            public string GetFirstName() {
                return firstName;
            }

            public string GetSurName() {
                return surName;
            }

        }
    }
