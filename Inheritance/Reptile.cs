using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            isAlive = true;
            age = 2;
            name = "Fred";
            legCount = 4;
        }

        public bool isColdBlooded { get; set; }
        public bool isScaly { get; set; }
        public string habitat { get; set; }
        public bool canGrowTail { get; set; }
    }
}
