using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company {
    class Person {
        private string firstName;
        private string surName;

        public Person(string firstName, string surName) {
            this.firstName = firstName;
            this.surName = surName;
        }

        public void setFirstName(string firstName) {
            this.firstName = firstName;
        }
        public void setSurName(string surName) {
            this.surName = surName;
        }
        public string getFirstName() {
            return firstName;
        }
        public string getSurName() {
            return surName;
        }
    }
}
