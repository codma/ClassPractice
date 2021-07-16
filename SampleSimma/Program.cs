using System;

namespace SampleSimma
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.WriteLine(animal.Breath());
            Console.WriteLine(animal.Sleep());
            Console.WriteLine(animal.Eat());
            Console.WriteLine(animal.Die());


            Animal bat = new Bat();

            Console.WriteLine(bat.Die());
            Console.WriteLine(bat.Eat());
            Console.WriteLine(((Bat)bat).Fly());



        }
    }
}


//캡슐화
//상속
//다형성
//추상화 abstract, interface