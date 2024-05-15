using System;

namespace animal
{
    class Program
    {
        abstract class Animal
        {
            public abstract string Type { get; }
            public abstract void MakeSound();

            public void Sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        class Pig : Animal
        {
            public override string Type => "Mamífero";

            public override void MakeSound()
            {
                Console.WriteLine("El cerdo hace oing");
            }
        }

        class Dog : Animal
        {
            public override string Type => "Mamífero";

            public override void MakeSound()
            {
                Console.WriteLine("El perro hace guau guau");
            }
        }

        class Chicken : Animal
        {
            public override string Type => "ave";

            public override void MakeSound()
            {
                Console.WriteLine("El pollo hace pio pio");
            }
        }

        class Cat : Animal
        {
            public override string Type => "Mamífero";

            public override void MakeSound()
            {
                Console.WriteLine("El gato hace miau miau");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------ANIMALES--------");

            Pig cerdo1 = new Pig();
            Console.WriteLine($"Tipo: {cerdo1.Type}");
            cerdo1.MakeSound();

            Dog perro1 = new Dog();
            Console.WriteLine($"Tipo: {perro1.Type}");
            perro1.MakeSound();

            Chicken pollo1 = new Chicken();
            Console.WriteLine($"Tipo: {pollo1.Type}");
            pollo1.MakeSound();

            Cat gato1 = new Cat();
            Console.WriteLine($"Tipo: {gato1.Type}");
            gato1.MakeSound();
        }
    }
}



