using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class MethodStoring
    {
        public static void ForFirstName()
        {
            Console.WriteLine("Rule for First Name:-\n1)only 3 character allowed.\n2)Only First char should capital");
            Console.WriteLine("\nEnter first name");
            string Nm = Console.ReadLine();

            User UR = new User();
            UR.firstName(Nm);
        }
        public static void ForLatName()
        {
            Console.WriteLine("\nRule for Last Name:-\n1)only 3 character allowed.\n2)Only First char should capital");
            Console.WriteLine("\nEnter Last Name : ");
            string Lm = Console.ReadLine();

            User UR = new User();
            UR.LastName(Lm);
        }
    }
}