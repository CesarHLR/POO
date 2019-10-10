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
        Console.WriteLine("Horas: {0} Minutos: {1} Segundos: {2}",Horas,Minutos, Segundos);
       }
       public int Seg(int H,int M, int S,int ST)
       { 
         H=H*3600;
         M=M*60;
         ST=H+S+M;

       }
       public void imprimeS()
       {
            Console.WriteLine("Segundos: {0}", ST);
       }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto de la clase
           Duracion hms=new Duracion(8,30,50);
           //hms.imprimeHMS();

           hms.Seg();
        }
    }
}