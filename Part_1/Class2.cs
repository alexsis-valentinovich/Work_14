using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Cat : Animals
    {
        string name;
        string sound;
        public override string Name
        {
            get => name;
            set => name = "Кошка";
        }
        public Cat(string name, string sound)
            : base(name)
        {
            Name = name;
            this.sound = sound;
        }

        public override void Say()
        {
            Console.WriteLine("Издает звук \"Мяу\"");
        }
    }
}