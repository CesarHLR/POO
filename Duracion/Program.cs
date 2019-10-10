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
       
       //Metodo para imprimir
       public void imprimeHMS()
       {
        Console.WriteLine("{0}:{1}:{2} hrs",Horas,Minutos, Segundos);
       }
       public void conversionSeg()
       {
           int S;
            S=(Horas*3600)+(Minutos*60)+Segundos;
            Console.WriteLine("Segundos: {0}", S);
       }
       public void conversionMin()
       {
           int M;
           M=(Horas*60)+Minutos+(Segundos/60);
           Console.WriteLine("Minutos: {0}",M);
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

           
        }
    }
}