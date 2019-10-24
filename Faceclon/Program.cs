using System;
using System.Collections.Generic;

namespace Faceclon
{
    abstract class Publicacion
    {
        protected string Usuario;
        protected string Hora;
        protected string Fecha;
        protected int Reacciones;
        protected int Comentarios;

        public  Publicacion(string u, string h, string f,int r,int c)
        {
            Usuario=u;
            Hora=h;
            Fecha=f;
            Reacciones=r;
            Comentarios=c;
        }
        public abstract void PublicaEstado();
    }
    class Estado:Publicacion
    {
        private string Texto;
        public Estado(string u, string h, string f,int r, int c, string t):base(u,h,f,r,c)
        {
            Texto=t;
        }
        public override void PublicaEstado()
        {
          Console.WriteLine(" {0} \n Publicado el {1} a las {2} \n {3} \n {4} Reacciones {5} Comentarios",Usuario,Fecha,Hora,Texto,Reacciones,Comentarios);
          Console.WriteLine("---------------------------------------------------------------------");
        }
    }
    class Foto:Publicacion
    {
        private string Texto;
        private string foto;
        private string Etiquetados;

        public Foto(string u, string h, string f, int r, int c, string t, string fo, string e):base(u,h,f,r,c)
        {
            Texto=t;
            foto=fo;
            Etiquetados=e;
        }
        public override void PublicaEstado()
        {
            Console.WriteLine(" {0} \n Publicado el {1} a las {2} \n {3} (Se encuentra con {4}) \n {5} \n {6} Reacciones {7} Comentarios",Usuario,Fecha,Hora,Texto,Etiquetados,foto,Reacciones,Comentarios);
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
    class Link:Publicacion
    {
        private string Texto;
        private string celda;
        public Link(string u,string h,string f,int r, int c,string t,string ce):base(u,h,f,r,c)
        {
            Texto=t;
            celda=ce;
        }
        public override void PublicaEstado()
        {
            Console.WriteLine(" {0} \n Publicado el {1} a las {2} \n {3} \n {4} \n {5} Reacciones {6} Comentarios",Usuario,Fecha,Hora,Texto,celda,Reacciones,Comentarios);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         Estado Pub= new Estado("Cesar Lopez","12:31 PM","23 de octubre 2019",10,2,"Estoy en clase de POO");
         Foto f=new Foto("Luis Rodriguez","12:48 PM","23 de octubre 2019",90,30,"Aqui en clase de POO","clase.jpg","Enrique");
         Link Celda=new Link("Esteban Armenta","12:50 PM","23 de octubre 2019",150,20,"Les comparto mi nueva cancion","https://www.youtube.com/watch?v=Z7OZ85Oiul8");

         List<Publicacion> pub=new List<Publicacion>();
         pub.Add(Pub);
         pub.Add(f);
         pub.Add(Celda);

         foreach(Publicacion P in pub)
         {
             P.PublicaEstado();
         }
        }
    }
}
