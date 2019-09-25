using System;

namespace Espias
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public Persona()
        {
            nombre="Fulano";
            apellido="De tal";

        }
    }
    class Anonymous
    {
        public  static void anonimiza(Persona p)
        {
            p.nombre="xxxxxx";
            p.apellido="xxxxx";

        }
        public static void cambia(ref Persona p)
        {
            p=new Persona();
            p.nombre="new";
        }
    }
    
  
    class Program
    {
        static void Main(string[] args)
        {
            
        Persona P=new Persona();
        Console.WriteLine(P.nombre);
        Anonymous.anonimiza(P);
        Anonymous.cambia(ref P);
        Console.WriteLine(P.nombre);


        }
    }
}
