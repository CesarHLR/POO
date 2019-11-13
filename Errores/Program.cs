using System;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
           int valor;
           Console.WriteLine("Ingresa tu edad: ");
           //string captura=Console.ReadLine();
           //Console.WriteLine(captura);
           //Console.ReadKey();
           try
           {
              string captura=Console.ReadLine();
              valor=int.Parse(captura);
              //console.WriteLine(valor);
              Console.WriteLine("En diez años tendras {0}",100/valor);
           }
           catch(FormatException)
           {
              Console.WriteLine("Formato incorrecto");
           }
           catch(DivideByZeroException)
           {
             Console.WriteLine("No has nacido");
           }   
           Console.ReadKey();
        }
    }
}
