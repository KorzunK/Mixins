using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_in
{
    public class Person : IAge
    {
        public int Age { get; set; }

        public void OtherAge()
        {
            this.MixAge();
        }
    }
}
