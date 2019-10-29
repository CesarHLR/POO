using System;
using System.Collections.Generic;

namespace Icompara
{
    class Persona:IComparable
    {
        int id;
        string nombre;
        public Persona(int id,string nombre)
        {
            this.id=id;
            this.nombre=nombre;
        }
    public override string ToString()
    {
        return string.Format("{0},{1}",id,nombre);
    }
    public Int32 CompareTo(Object o)
    {
      return this.id.CompareTo(((Persona)o).id);
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> pers=new List<Persona>();
            pers.Add(new Persona(2,"Pam"));
            pers.Add(new Persona(1,"Jim"));
            pers.Add(new Persona(3,"Mike"));
            foreach(Persona p in pers)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Lista ordenada por id");
            pers.Sort();
              foreach(Persona p in pers)
            {
                Console.WriteLine(p);
            }
          
        }
    }
}
