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
        public List<Producto> productos = new List<Producto>();
        public void EscribeProductosTXT(string archivo)
		{
			try {
				//use la clase filestream para abrir el archivo o crearlo en caso que no exista
				FileStream Fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
				//Crea un escritor para el archivo
				using(StreamWriter txtOut=new StreamWriter(Fs))
				{
					foreach(Producto p in productos)
					{
						txtOut.WriteLine("{0}▬{1}▬{2}▬{3}▬{4}",p.Codigo,p.Descripcion,p.Precio,p.Departamento,p.Likes);
					}
				}
			} catch(IOException ex) {
				Console.WriteLine("[ERROR] No se pudo abrir el archivo ("+ex.Message+")");
			} catch(Exception ex) {
				Console.WriteLine("[ERROR] Hay error en la escritura ("+ex.Message+")");
			}
		}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
