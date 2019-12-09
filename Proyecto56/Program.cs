using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Proyecto56
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
				//Abre el archivo
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
		public void LeerProductosTXT(string archivo)
		{
			try {
				// Abre el archivo
				FileStream Fs2=new FileStream(archivo,FileMode.Open,FileAccess.Read);
				// 
				using(StreamReader txtOut=new StreamReader(Fs2)) {
					string renglon;
					//Es para leer de renglon en renglon
					//Split: es para partir el string
					while((renglon = txtOut.ReadLine()) != null) 
					{
						string[] sp = renglon.Split("▬");
						if(sp.Length < 5)
							throw new Exception("Formato  incorrecto");
						productos.Add(new Producto(sp[0], sp[1], decimal.Parse(sp[2]), int.Parse(sp[3]), int.Parse(sp[4])));
					}
				}
			} catch(IOException ex) {
				Console.WriteLine("[ERROR] No se pudo abrir el archivo ("+ex.Message+")");
			} catch(Exception ex) {
				Console.WriteLine("[ERROR] Hay error en la escritura ("+ex.Message+")");
			}
		}
		public void EscribeProductosBIN(string archivo)
		{
			try {
				//Abre el archivo
				FileStream Fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
				//Crea un escritor para el archivo
				using(BinaryWriter binOut=new BinaryWriter(Fs))
				{
					foreach(Producto p in productos)
					{
						binOut.Write(p.Codigo);
						binOut.Write(p.Descripcion);
						binOut.Write(p.Precio);
						binOut.Write(p.Departamento);
						binOut.Write(p.Likes);
					}
				}
			} catch(IOException ex) {
				Console.WriteLine("[ERROR] No se pudo abrir el archivo ("+ex.Message+")");
			} catch(Exception ex) {
				Console.WriteLine("[ERROR] Hay error en la escritura ("+ex.Message+")");
			}
		}
		public void LeerProductosBIN(string archivo)
		{
			try {
				// Abre el archivo
				FileStream Fs2=new FileStream(archivo,FileMode.Open,FileAccess.Read);
				// 
				using(BinaryReader binIn=new BinaryReader(Fs2)) {
					while(binIn.PeekChar() != -1) 
					{
						productos.Add(new Producto(binIn.ReadString(), binIn.ReadString(), binIn.ReadDecimal(), binIn.ReadInt32(), binIn.ReadInt32()));
					}
				}
			} catch(IOException ex) {
				Console.WriteLine("[ERROR] No se pudo abrir el archivo ("+ex.Message+")");
			} catch(Exception ex) {
				Console.WriteLine("[ERROR] Hay error en la escritura ("+ex.Message+")");
			}
		}
		public void GetDepartment(int Depto) {
			IEnumerable<Producto> pds =
				from p in productos
				where p.Departamento == Depto
				select p;
			Console.WriteLine("Se mostraran los productos del departamento: "+Depto);
			foreach(Producto p in pds) {
				Console.WriteLine("{0},{1},{2},{3},{4}",p.Codigo,p.Descripcion,p.Precio,p.Departamento,p.Likes);
			}
		}
		public void OrdenarLikes() {
			IEnumerable<Producto> pds =
				from p in productos
				orderby p.Likes
				select p;
			Console.WriteLine("Se mostraran los productos en orden de likes:");
			foreach(Producto p in pds) {
				Console.WriteLine("{0},{1},{2},{3},{4}",p.Codigo,p.Descripcion,p.Precio,p.Departamento,p.Likes);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			ProductoDB Ejem1=new ProductoDB();
          /*Ejem1.productos.Add(new Producto("S4TSDS", "Soda",12, 1, 16));
			Ejem1.productos.Add(new Producto("S4TSDS", "Soda",12, 1, 19));
			Ejem1.productos.Add(new Producto("S4TSDS", "Sabritas",12, 1, 1));
			Ejem1.productos.Add(new Producto("S4TSDS", "paleta",12, 5, 17));
			Ejem1.EscribeProductosTXT("productos.txt");
			Ejem1.EscribeProductosBIN("productos.bin");*/
			Ejem1.LeerProductosTXT("productos.txt");
			Ejem1.OrdenarLikes();
			
		}
	}
}