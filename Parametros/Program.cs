using System;

namespace Parametros
{
 class Futbol
    {
        public string Equipo;
        
        public Futbol()
        {
          Equipo="Real Madrid";
          
        }
      
    }
    class Equipo
    {
        //Abreviar nombre del equipo mediante pase de parametros Ref
        public static void CambiaSiglas(ref Futbol e)
        {
            e=new Futbol();
            e.Equipo="MAD";
        }   
        public void Año(in int año)
        {
           
           
        }
        
    }
    class Titulos
    { 
        //Calcular titulos totales del equipo mediante parametro Out
        //Titulos de liga y titulos de champions
       public static void suma(int TL, int TCh, out int T)
        {
           T=TL+TCh;
        }
        public static int suma(int TL,int TCh)
        {
          return TL+TCh;
        }
    }

      
        class program
        {
           static void Main(string[] args)
           {
             int TitulosL=33;
             int TitulosC=13;
             int TotalT;

             Titulos.suma(TitulosL,TitulosC,out TotalT);
             Console.WriteLine("Titulos totales del club entre Liga y Champions: "+TotalT);

            

              Futbol Eq=new Futbol();
              Console.WriteLine("Equipo: "+ Eq.Equipo);
              Equipo.CambiaSiglas(ref Eq);
              Console.WriteLine("Abreviacion:"+ Eq.Equipo);
           }
        
       }  
}
