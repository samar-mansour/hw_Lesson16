using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hw16_0507
{
    abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Name: {this.name}";
        }
    }
}
