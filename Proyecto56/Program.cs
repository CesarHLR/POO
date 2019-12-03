using System;
using System.IO;
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
    public Producto(){}
}
 class ProductoDB
    {
        public static void EscribeProductos(string archivo,List<Producto>productos)
    {
        FileStream Fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
        StreamWriter txtOut=new StreamWriter(Fs);
        foreach(Producto p in productos)
        {
            txtOut.WriteLine("{0}{1}{2}{3}{4}",p.Codigo,p.Descripcion,p.Precio,p.Departamento,p.Likes);
        }
        txtOut.Close();
    }
    public static List<Producto> LeerProductos(string archivo)
    {
        List<Producto>productos=new List<Producto>();
        FileStream Fs2=new FileStream(archivo,FileMode.Open,FileAccess.Read);
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
