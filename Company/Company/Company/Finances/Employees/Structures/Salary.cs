using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Finances.Employees.Structures {

    public struct Salary {
        private float basic;
        private float bonus;
        private float other;

        public Salary(float basic = 0, float bonus = 0, float other = 0) {
            this.basic = basic;
            this.bonus = bonus;
            this.other = other;
        }

        public void SetBasic(float value) {
            this.basic = value;
        }
        public void SetBonus(float value) {
            this.bonus = value;
        }
        public void SetOther(float value) {
            this.other = value;
        }
        public float GetBasic() {
            return basic;
        }
        public float GetBonus() {
            return bonus;
        }
        public float GetOther() {
            return other;
        }
    }
}
