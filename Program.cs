using System;
using HeadFirstDesignPatterns.Strategy.Duck;


namespace DucksCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulador de patos");
            Console.WriteLine("------------------");

            Duck mallard = new MallardDuck();
            Console.WriteLine(mallard.PerformQuack());
            Console.WriteLine(mallard.PerformFly()); 

            Duck model = new ModelDuck();

            Console.WriteLine(model.PerformFly());
                      
        }
    }
}
