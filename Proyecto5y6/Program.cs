using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto5y6
{
    class Producto
	{
		public string Codigo;
		public string Descripcion;
		public Decimal Precio;
		public int Departamento;
		public int Likes;
		public Producto(string c,string d,decimal p, int dep, int l)
		{
			Codigo=c;
			Descripcion=d;
			Precio=p;
			Departamento=dep;
			Likes=l;
		}
	}
    class ProductoDB
	{
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
