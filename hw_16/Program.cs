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

        static Horse [] GetRacingHorse(Horse[] horses)
        {
            Horse[] racing = TotalRacingHorse(horses);

            CreateNewRacingHorses(horses, racing);

            return racing;
        }

        static Horse[] TotalRacingHorse(Horse[] horses)
        {
            int num = 0;

            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].racingHorse)
                {
                    num++;
                }
            }
            Horse[] racing = new Horse[num];
            return racing;
        }

        static void CreateNewRacingHorses(Horse[] horses, Horse[] racingHorses)
        {
            int index = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].racingHorse)
                {
                    racingHorses[index] = horses[i];
                    index++;
                }
            }
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

            Console.WriteLine("=============Animal Sing===================");
            Animal[] a = new Animal[] { boney, husky, beardog, blackWolf, pet };
            AnimalSing(a);

            Console.WriteLine("=============Animals====================");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("=============Racing Horses==================");
            Horse[] h = new Horse[]{ boney, dark,arabian};
            Horse[] racing = GetRacingHorse(h);
            Console.WriteLine($"Number Of Racing Horses: {racing.Length}");
            for (int i = 0; i < racing.Length; i++)
            {
                Console.WriteLine(racing[i]);
            }
            


        }
    }
}
