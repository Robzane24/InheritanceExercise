using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        { 
            isAlive= true;
            age = 1;
            name = "Larry";
            legCount = 2;
        }

        public bool canFly { get; set; }
        public int wingCount { get; set; }
        public bool willMigrate { get; set; }
        public bool hasBeak { get; set; }
    }

}
