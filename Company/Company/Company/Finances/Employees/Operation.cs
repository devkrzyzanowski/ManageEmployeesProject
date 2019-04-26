using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Finances.Employees {

        public class Operation {
            private string label;
            private string type;
            private decimal amount;

            public Operation(string label, string type, decimal amount) {
                this.label = label;
                this.type = type;
                this.amount = amount;
            }

            public void PrintOperationInfo() {
                Console.WriteLine(
                        "Operation: {0} is a {1} on amount {2}.",
                        label, type, amount
                    );
            }

            public void SetLabel(string value) {
                label = value;
            }

            public void SetType(string value) {
                type = value;
            }

            public void SetAmount(decimal value) {
                amount = value;
            }

            public string GetLabel() {
                return label;
            }

            public string GetType() {
                return type;
            }

            public decimal GetAmount() {
                return amount;
            }

        }
    }