using System;
using System.Collections.Generic;


namespace Musico
{
    class Musico
    {
        protected string nombre;
        public Musico(string n)
        {
            nombre=n;
        }
        //Virtual: permite remplazar su propio metodo por medio de herencia
        public virtual void Afina()
        {
           Console.WriteLine("{0}, Afina su instrumento",nombre);
        }
        public virtual string Saluda()
        {
           return string.Format("Hola, soy {0}",nombre);
        }
    }
    class Bajista: Musico
    {
        private string bajo;
        public Bajista(string no, string bajo):base(no)
        {
            this.bajo=bajo;
        } 
        //override: remplazar metodos
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su bajo {1}",nombre,bajo);
        }
        public override string Saluda()
        {
            return base.Saluda()+" y soy bajista";
        }
    }
     class Guitarrista: Musico
     {
         private string guitarra;
         public Guitarrista(string no,string guitarra):base(no)
         {
             this.guitarra=guitarra;
         }
         public override void Afina()
         {
             Console.WriteLine("{0} Afinando su guitarra {1}",nombre,guitarra);
         }
         public override string Saluda()
         {
             return base.Saluda()+" y soy guitarrista";
         }
     }
    class Program
    {
        static void Main(string[] args)
        {
            Musico cesar=new Musico("Cesar");
            Bajista Humberto=new Bajista("Humberto","Gibson");
            Guitarrista Lopez=new Guitarrista("Lopez","Gibson");

            /*cesar.Saluda();
            cesar.Afina();

            Humberto.Saluda();
            Humberto.Afina();*/

            List <Musico> grupo=new List<Musico>();
            grupo.Add(cesar);
            grupo.Add(Humberto);
            grupo.Add(Lopez);
            foreach(Musico m in grupo)
            {
                Console.WriteLine(m.Saluda());
                m.Afina();
            }
        }
    }
}
