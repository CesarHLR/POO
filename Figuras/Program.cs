using System;
using System.Collections.Generic;

namespace Figuras
{
    abstract class Figura
    {
      protected int ancho,largo;
      protected int px,py;
      protected string color_relleno,color_borde;
      
      public abstract void dibuja();

      public Figura(int a,int l,int x,int y, string cr, string cb)
      {
           ancho=a;
           largo=l;
           px=x;
           py=y;
           color_relleno=cr;
           color_borde=cb;
      }
    }
    class Rectangulo:Figura
    {
        public Rectangulo(int a, int l,int x, int y, string cr, string cb):base(a,l,x,y,cr,cb)
        {

        }
        public override void dibuja()
        {
            Console.WriteLine("Se dibuja en rect color{0}, en x:{1} y y:{2}", color_relleno,px,py);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura>Figuras=new List<Figura>();
            Figuras.Add(new Rectangulo)
        }
    }
}
