using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_in
{
    public static class Mixin
    {
        public static void MixAge(this IAge age)
        {
            Console.WriteLine("{0} years", age.Age);
        }
    }
}
