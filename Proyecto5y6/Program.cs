﻿using System;
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
        public void LeerProductosTXT(string archivo)
		{
			try {
				// Use la clase filestream para abrir al archivo
				FileStream Fs2=new FileStream(archivo,FileMode.Open,FileAccess.Read);
				using(StreamReader txtOut=new StreamReader(Fs2)) {
					string renglon;
					//Es para leer de renglon en renglon
					//Split: Sirve para dividir una cadena en partes utilizando un caracter delimitador
					while((renglon = txtOut.ReadLine()) != null) 
					{
						string[] ren = renglon.Split("▬");
						if(renglon.Length < 5)
                        {
                           throw new Exception("Formato  incorrecto");
                        }
                        else
                        {
                          productos.Add(new Producto(ren[0], ren[1], decimal.Parse(ren[2]), int.Parse(ren[3]), int.Parse(ren[4])));
                        }	
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
				//use la clase filestream para abrir el archivo o crearlo en caso que no exista tipo binario
				FileStream Fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
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
			try 
            {
				// Use la clase filestream para abrir al archivo tipo binario
				FileStream Fs2=new FileStream(archivo,FileMode.Open,FileAccess.Read);
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}