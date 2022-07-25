using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Dog : Animals
    {
        string name;
        string sound;
        public override string Name
        {
            get => name;
            set => name = "Собака";
        }
        public Dog(string name, string sound)
            : base(name)
        {
            Name = name;
            this.sound = sound;
        }

        public override void Say()
        {
            Console.WriteLine("Издает звук \"Гав\"");
        }
    }
}
