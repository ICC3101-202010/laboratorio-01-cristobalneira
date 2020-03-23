using System;
namespace Proyecto1Neira
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string GetName()
        {
            return nombre;
        }

        public string GetApe()
        {
            return apellido;
        }

        public int Lanzar()
        {
            Random rdn = new Random();
            int a = rdn.Next(0, 3);
            return a;
        }

    }
    
}
