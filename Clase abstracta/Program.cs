using System;
using System.Timers;
namespace animal
{
    class Program
    {
        abstract class Animal
        {
            public abstract void animalSound();
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        class Pig : Animal
        {

            public override void animalSound() 
            {
                Console.WriteLine("el cerdo hace oing");
            }
        }

        class Dog : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("el perro hace guau guau");
            }
        }

        class Cat : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("el gato hace miau miau");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("---------ANIMALES--------");
            Pig Cerdo1 = new Pig();
            Cerdo1.animalSound();

            Dog Dog1 = new Dog();
            Dog1.animalSound();
            
            Cat Cat1 = new Cat();
            Cat1.animalSound();


        }



    }





}




