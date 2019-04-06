using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company {

    struct Salary {
        public float basic;
        public float bonus;
        public float other;
    }
    enum Contract {
        FullTime,
        PartTime,
        Contract
    }


    class Employee {
        private Salary sal;
        private Contract con;

        public Employee(float basic, float bonus, float other) {
            this.sal.basic = basic;
            this.sal.bonus = bonus;
            this.sal.other = other;
            this.con.FullTime;
        }

    }
}
