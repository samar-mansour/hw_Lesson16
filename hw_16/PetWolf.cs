using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw16_0507
{
    sealed class PetWolf:Wolf
    {
        public PetWolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood,nameOfPack)
        {
        }

        public override void Bark()
        {
            Console.WriteLine("");
        }

        public override string ToString()
        {
            return $"pet wolf {base.ToString()}";
        }
    }
}
