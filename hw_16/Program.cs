using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw16_0507
{
    class Program
    {
        static void AnimalSing(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }  
        }

        static string [] GetRacingHorse(Horse[] horses)
        {
            int num = horses.Length;
            string [] racing = new string[num];
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].racingHorse)
                {
                    racing[i] = horses[i].name;
                }
            }
            return racing;
        }
        

        static void Main(string[] args)
        {
            Horse boney = new Horse("Light", false);
            Horse dark = new Horse("Soul", true);
            Horse arabian = new Horse("Speedy", true);

            Dog husky = new Dog("Lobo","Lam");
            Poodle beardog = new Poodle("Moki","Bone", "1");
            Wolf blackWolf = new Wolf("Zen", "Ham", "Spirit");
            PetWolf pet = new PetWolf("Gray","Milk","Spirit");

            Animal[] a = new Animal[] { boney, husky, beardog, blackWolf, pet };
            AnimalSing(a);


            Horse[] h = new Horse[]{ boney, dark,arabian};
            for (int i = 0; i <h.Length; i++)
            {
                Console.WriteLine(GetRacingHorse(h)[i]);
            }

        }
    }
}
