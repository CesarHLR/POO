using System;

namespace Duracion
{
    class Duracion
    {
       public  int Horas;
       public int Minutos;
       public int Segundos;

        //Constructor
        public Duracion(int H, int M, int S )
        {
            this.Horas=H;
            this.Segundos=S;
            this.Minutos=M;
        }
         //Metodo para imprimir hrs, min y seg
        public void imprimeHMS()
       {
        Console.WriteLine("{0}:{1}:{2} hrs",Horas,Minutos, Segundos);
       }
       //Metodo convertir la hora a segundos
       public void conversionSeg()
       {
          int S;
          S=(Horas*3600)+(Minutos*60)+Segundos;
            Console.WriteLine("Hora en Segundos: {0}", S);
       }
    
       //Metodo convertir la hora a minutos
       public void conversionMin()
       {
           int M;
           M=(Horas*60)+Minutos+(Segundos/60);
           Console.WriteLine("Hora en Minutos: {0}",M);
       }
        //Constructor segundos
        public Duracion(int S)
        {
            this.Segundos=S;

            Horas=(int) S/3600;
            Minutos=(int)(S-(Horas*3600))/60;
            Segundos=(int)S-(Horas*3600)-(Minutos*60);
        }
        //Imprimir de seg a Hrs, min y seg
        public void imprimeSaHMS()
        {
            Console.WriteLine("{0}:{1}:{2} hrs",Horas,Minutos,Segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           //Crear objeto de la clase
           Duracion hms=new Duracion(8,30,50);
           hms.imprimeHMS();
           hms.conversionSeg();
           hms.conversionMin();

           Duracion SaHMS=new Duracion(7000);
           Console.WriteLine("7000 segundos equivalen a: ");
           SaHMS.imprimeSaHMS();
        }
    }
}