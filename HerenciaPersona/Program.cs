using System;

namespace HerenciaPersona
{
    class Persona
    {
        protected string nombre;
        public string Nombre 
        {
            get {return nombre;}
        }
        public Persona(string n)
        {
            nombre=n;
        }
        public void print()
        {
            Console.WriteLine("Mi nombre es:{0} ", nombre);
        }
    }
    class Alumno : Persona
    {
        //Protected(pone el atributo privado, pero que se pueda heredar a la otra clase)
       protected string num_control;
       //base(usa contrustor de la clase base)
       public Alumno(string nombre, string num_control):base(nombre)
       {
           this.num_control=num_control;
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Persona cesar=new Persona("Cesar");
           Persona humberto=new Persona("Humberto");
           Alumno luis=new Alumno("Luis","19210519");

            cesar.print();
            humberto.print();
            luis.print();
        }
    }
}
