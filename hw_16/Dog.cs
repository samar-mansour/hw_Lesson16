using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw16_0507
{
    class Dog : Animal
    {
        public string favoriteDogFood;
        public Dog(string name, string favoriteDogFood) : base(name)
        {
            this.favoriteDogFood = favoriteDogFood;
        }
        public override void MakeSound()
        {
            this.Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Wooo");
        }

        public override string ToString()
        {
            return $"Dog: {base.ToString()} Favorite Food: {favoriteDogFood}";
        }
    }
}
