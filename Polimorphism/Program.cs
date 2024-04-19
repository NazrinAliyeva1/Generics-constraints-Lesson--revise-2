using Polimorphism.Interfaces;
using Polimorphism.Models;

namespace Polimorphism
{
    class Program
    {
        static void Main()
        {
            //Shark akula = new Shark("Akula");
            //Eagle qartal = new Eagle("Shahin");
            //Cat mestan = new("Şahin");
            //Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };
            //Animal a = new Shark("Akula");
            //a.Eat();
            //foreach (var animal in animals)
            //{
            //    animal.Eat();
            //}
            //ISwim dog = new Dog("Toplan");
            //ISwim fish = new Shark("Akula");
            //ISwim[] swimmers = new ISwim[] { fish, dog };
            //foreach (var swimmer in swimmers)
            //{
            //    swimmer.Swim();
            //}
            //IDivide c = new Calculate();
            //Console.WriteLine(c.Divide(1, 5));

            Heyvan<Eagle> park = new(new Eagle[]
            { 
                new Eagle("Shahin"),
                new Eagle("Qartal")
            });
            Heyvan<Bird> park2 = new(new Eagle[]
            {
                new Eagle("Shahin"),
                new Eagle("Qartal")
            });
            Heyvan<Dog> park3 = new(new Dog[]
            {
                new Dog("Alabay"),
                new Dog("Toplan")
            });
            Heyvan<Shark> park4 = new(new Shark[]
{
                new Shark("Alabay"),
                new Shark("Toplan")
});

        }

        class Heyvan<T> where T :Animal, ISwim, new()
        {
            public T[] Animals { get; private set;  }
            public Heyvan(T[] arr)
            {
                Animals = arr;
            }
        }
    }
}
