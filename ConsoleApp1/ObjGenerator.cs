using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ObjectsGenerator
    {
        public IWalkable[] GenerateWalkable(int count)
        {
            IWalkable[] walkables = new IWalkable[count];
            for (int i = 0; i < count; i++)
            {
                if(i < count / 2)
                walkables[i] = new Person();
                else
                walkables[i] = new Horse();
            }
            return walkables;
        }

    }
}
