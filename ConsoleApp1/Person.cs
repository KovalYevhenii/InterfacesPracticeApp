using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
   public class Person : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine($"Human walked 500m.");
        }
    }

}
