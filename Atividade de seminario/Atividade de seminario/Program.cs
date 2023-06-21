using System;

namespace ExemploInterface
{
    public interface IAnimal
    {
        void EmiteSom();
    }
    public class Cachorro : IAnimal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Cachorro late");
        }
    }
    public class Gato : IAnimal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Gato mia");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            IAnimal cachorro1 = new Cachorro();
            IAnimal gato1 = new Gato();

            cachorro1.EmiteSom();
            gato1.EmiteSom();
        }
    }
}
