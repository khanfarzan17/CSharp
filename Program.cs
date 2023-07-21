using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDetail p1 = new PersonDetail();
            p1.name = "Farzan";
            p1.age = 22;
            p1.gender = "male";
            p1.salary = 375000;

            Console.WriteLine(" "+ p1.name);
            Console.WriteLine(" " + p1.age);
            Console.WriteLine(" " + p1.gender);
            Console.WriteLine(" " + p1.salary);





            Console.Read();

        }
    }
}
