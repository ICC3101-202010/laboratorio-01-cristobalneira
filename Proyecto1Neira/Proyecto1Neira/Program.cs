using System;
//Profesor dijo con rigurosidad cada Parte
namespace Proyecto1Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Parte1
            Persona person1 = new Persona("","");
            person1.Lanzar();
            //Parte2 ocupar el constructor
            Persona person2 = new Persona("Bob", "Kunga");

        }
    }
}