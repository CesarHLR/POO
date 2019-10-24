using System;

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
          Console.WriteLine("Usuario: {0} \n fecha: {1} Hora: {2} \n {3} \n Reacciones: {4} Comentarios: {5}",Usuario,Fecha,Hora,Texto,Reacciones,Comentarios);
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
            Console.WriteLine("Usuarios: {0} \n Fecha: {1}  Hora: {2} \n {3} con: {4} \n {5} \n Reacciones: {6} Comentarios: {7}",Usuario,Fecha,Hora,Texto,Etiquetados,foto,Reacciones,Comentarios);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         Estado Pub= new Estado("Cesar","12:31 PM","23 oct 2019",10,2,"Estoy en clase de POO");
         Pub.PublicaEstado();

         Foto f=new Foto("Cesar","12:48 PM","23 oct 2019",90,30,"Aqui en clase de POO","clase.jpg","Enrique");
         f.PublicaEstado();
        }
    }
}
