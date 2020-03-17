using System;

namespace Laboratorio_01_jcgubbins99
{  //Alumno: Juan Carlos Gubbins  
    public class Persona    //Se crea la clase persona
    {
        //Atributos
        public string Nombre;

        public string Apellido;

        public Persona(string _nombre, string _apellido) //constructor
        {
            Nombre = _nombre;
            Apellido = _apellido;
        }
        //Método o acción
        public int Lanzar()
        {

            Random random = new Random();
            return random.Next(0, 3); //piedra(0), papel(1) o tijeras(2) numero aleatorio
        }

    }

    class Program    //Clase la cual va a llamar a la clase Persona a realizar su acción "Lanzar"
    {
        static void Main()
        {
            Persona p1 = new Persona("Bob", "Kunga");
            int Lanza1 = 0; //Variable =0
            Lanza1 = p1.Lanzar();

            Console.WriteLine(Lanza1);



        }
    }
}
