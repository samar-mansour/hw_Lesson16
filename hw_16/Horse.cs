using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw16_0507
{
    class Horse : Animal
    {
        public bool racingHorse;
        public Horse(string name, bool racingHorse):base(name)
        {
            this.racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            this.Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("Neigh");
        }

        public override string ToString()
        {
            return $"Horse: {base.ToString()} {this.racingHorse}";
        }
    }
}
