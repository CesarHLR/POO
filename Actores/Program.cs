using System;
using System.Collections.Generic;

namespace Actores
{
    class Actor
    {
       public string Nombre;
       public Int16 Año;

       public Actor(string nombre, Int16 año)
       {
         this.Nombre=nombre;
         this.Año=año;
       }
      
    }
    class Peli
    {
        private string Titulo;
        private Int16 Año;
        private string Pais;
        private string Director;    
        private List<Actor> actores=new List<Actor>();
        public void AgregarActor(Actor actor)
        {
         actores.Add(actor);
        } 
        
        public void ImprimeActor()
        {
            foreach(Actor Ac in actores)
            {
            Console.WriteLine("{0}({1})",Ac.Nombre,Ac.Año);
            }
        }
        //Metodo Titulo
        public void setTitulo(string Titulo)
        {
           this.Titulo=Titulo;
        }
        public string getTitulo()
        {
            return this.Titulo;
        }
        //Metodo Año
         public void setAño(Int16 Año)
        {
           this.Año=Año;
        }
        public Int16 getAño()
        {
            return this.Año;
        }
        //Metodo Pais
         public void setPais(string Pais)
        {
           this.Pais=Pais;
        }
        public string getPais()
        {
            return this.Pais;
        }
        //Metodo director
         public void setDirector(string Director)
        {
            this.Director=Director;
        }
        public string getDirector()
        {
            return this.Director;
        }
        //Constructor
        public Peli(string T, Int16 A)
        {
          this.Titulo=T;
          this.Año=A;
        }
        //SobreCarga
        public Peli()
        {

        }
        //Metodo para imprimir
        public void Imprime()
        {
            Console.WriteLine("{0}({1})",this.getTitulo(),this.getAño());
        }
    }
      class Program
    {
        static void Main(string[] args)
        {
            Peli P1=new Peli("Pelicula ganadora al oscar: La forma del agua",2017);
            P1.AgregarActor(new Actor("Actor: Sally Hawkins",1976));
            P1.Imprime(); 
            P1.ImprimeActor();

            Peli P2=new Peli("Pelicula ganadora al oscar: Roma",2018);
            P2.AgregarActor(new Actor("Actor: Yalitza Aparicio",1993));
            P2.Imprime();
            P2.ImprimeActor();
        } 

    }
   
}
