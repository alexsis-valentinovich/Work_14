using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    abstract class Animals
    {
        public abstract string Name { get; set; }
        public Animals(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("Животное: {0}", Name);
            Say();
        }


    }
}
