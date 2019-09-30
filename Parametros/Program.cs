using System;

namespace Parametros
{
 class Equipo
    {
        public string nombre;
        
        public Equipo()
        {
          nombre="Real Madrid";
          
        }
        //Año de fundacion del equipo con parametrio in
        //Esta vacio porque el año de fundacion no cambia
       public void Año(in Int16 año)
        {
           
        }
    }
    class Abreviatura
    {
        //Abreviar nombre del equipo mediante pase de parametros Ref
        public static void CambiaSiglas(ref Equipo e)
        {
            e=new Equipo();
            e.nombre="MAD";
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
             Int16 A=1902;

             Titulos.suma(TitulosL,TitulosC,out TotalT);
             Console.WriteLine("Titulos totales del club entre Liga y Champions: "+TotalT);
              Equipo Eq=new Equipo();
              Console.WriteLine("Equipo: "+ Eq.nombre);
              Abreviatura.CambiaSiglas(ref Eq);
              Console.WriteLine("Abreviacion: "+ Eq.nombre);
              Eq.Año(in A);
              Console.WriteLine("Año de fundacion: "+ A);
           }
        
       }  
}
