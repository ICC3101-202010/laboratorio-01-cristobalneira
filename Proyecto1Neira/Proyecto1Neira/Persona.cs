using System;
namespace Proyecto1Neira
{
    // Parte1
    public class Persona
    {
        private string nombre;
        private string apellido;

        public void Lanzar()
        {
            Random rdn = new Random();
            int a = rdn.Next(0, 3);
            Console.WriteLine(a);
        }
        // Parte2
        //Constructor de la clase Persona
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}


