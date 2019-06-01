using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Finances.Employees {
    class Security {
        public static bool logged = false;

        public static bool LogIn() {
            if (logged == false) {
                tryLog();
            } else {
                logged = false;
                tryLog();
            }
            return logged;
        }

        public static bool tryLog() {
            Console.WriteLine("Login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if (login == "boss" && password == "1234") {
                logged = true;
            }
            return logged;
        }
    }
}
