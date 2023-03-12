using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectsGenerator generator = new();

            IWalkable[] walkables = generator.GenerateWalkable(10);

            foreach (IWalkable walkable in walkables)
            {
                walkable.Walk();
            }
        }
       

    }


}