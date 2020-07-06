using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw16_0507
{
    class Poodle : Dog
    {
        public string numberOfPonyTails;
        public Poodle(string name, string favoriteDogFood, string numberOfPonyTails) : base(name, favoriteDogFood)
        {
            this.numberOfPonyTails = numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("woof");
        }

        public override string ToString()
        {
            return $"Poodle: {base.ToString()} {numberOfPonyTails}";
        }
    }
}
