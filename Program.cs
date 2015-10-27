using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_in
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pluto = new Dog {Age = 5};
            pluto.OtherAge();

            Dog scooby = new Dog {Age = 6};
            scooby.OtherAge();

            Person men = new Person {Age = 48};
            men.OtherAge();

            Console.ReadLine();
        }
    }
}
