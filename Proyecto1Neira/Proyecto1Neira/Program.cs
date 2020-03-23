using System;

namespace Proyecto1Neira
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona person1 = new Persona("Bob", "Kunga");
            Console.WriteLine("Nombre: " + person1.GetName());
            Console.WriteLine("Apellido: " + person1.GetApe());
            Console.WriteLine("Persona lanzo: " + person1.Lanzar());
        }
    }
}