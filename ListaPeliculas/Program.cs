using System;
using System.Collections.Generic;

namespace ListaPeliculas
{
    class Program
    {
        static void Main(string[] args)
        {
           List<String> lista=new List<string>();
           lista.Add("Pelicula 1: Ex Machina");
           lista.Add("Pelicula 2: American History X");
           lista.Add("Pelicula 3: La forma del agua");
           lista.Add("Pelicula 4: Roma");
           lista.Add("Pelicula 5: Spirit");

           foreach(string Peliculas in lista)
           Console.WriteLine(Peliculas);
        }
    }
}
