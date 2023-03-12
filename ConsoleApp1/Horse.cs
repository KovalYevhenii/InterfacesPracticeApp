using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Horse : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Horse went 5000m");
        }
    }
}
