using System;

namespace Peliculas
{
    class Peli
    {
        public string Titulo;
        public Int16 Año;
        public string Pais;
        public string Director;      
    }
      class Program
    {
        static void Main(string[] args)
        {
            Peli P1=new Peli();
            P1.Titulo="La forma del agua";
            P1.Año=2017;
            P1.Pais="Estados Unidos";
            P1.Director="Guillermo del toro";
            Console.WriteLine( "Pelicula ganadora al oscar: "+ P1.Titulo +"\nAño: " +P1.Año );

            Peli P2=new Peli();
            P2.Titulo="Roma";
            P2.Año=2018;
            P2.Pais="México";
            P2.Director="Alfonso cuarón";
            Console.WriteLine( "Pelicula ganadora al oscar: "+ P2.Titulo +"\nAño: " +P2.Año );




        }
    }
}
