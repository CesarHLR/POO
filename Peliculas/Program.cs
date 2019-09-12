using System;

namespace Peliculas
{
    class Peli
    {
        private string Titulo;
        private Int16 Año;
        private string Pais;
        private string Director;      
        //Metodo Titulo
        public void setTitulo(string Titulo)
        {
           this.Titulo=Titulo;
        }
        public string getTitulo()
        {
            return this.Titulo;
        }
        //Metodo Año
         public void setAño(Int16 Año)
        {
           this.Año=Año;
        }
        public Int16 getAño()
        {
            return this.Año;
        }
        //Metodo Pais
         public void setPais(string Pais)
        {
           this.Pais=Pais;
        }
        public string getPais()
        {
            return this.Pais;
        }
        //Metodo director
         public void setDirector(string Director)
        {
            this.Director=Director;
        }
        public string getDirector()
        {
            return this.Director;
        }
        //Constructor
        public Peli(string T, Int16 A)
        {
          this.Titulo=T;
          this.Año=A;
        }
        //SobreCarga
        public Peli()
        {

        }
        //Metodo para imprimir
        public void Imprime()
        {
            Console.WriteLine("{0}({1})",this.getTitulo(),this.getAño());
        }
    }
      class Program
    {
        static void Main(string[] args)
        {
            Peli P1=new Peli("Pelicula ganadora al oscar: La forma del agua",2017);
            P1.Imprime(); 

            //P1.setTitulo("La forma del agua");
            // P1.setAño(2017);
            //Console.WriteLine("{0}({1})","Pelicula ganadora al oscar: "+ P1.getTitulo(), P1.getAño());
            //P1.Titulo="La forma del agua";
            //P1.Año=2017;
            //P1.Pais="Estados Unidos";
            //P1.Director="Guillermo del toro";
            //Console.WriteLine( "Pelicula ganadora al oscar: "+ P1.Titulo +"\nAño: " +P1.Año );

            Peli P2=new Peli("Pelicula ganadora al oscar: Roma",2018);
            P2.Imprime();

            //P2.setTitulo("Roma");
            //P2.setAño(2018);
            //Console.WriteLine("{0}({1})","Pelicula ganadora al oscar: "+ P2.getTitulo(), P2.getAño());
            //P2.Titulo="Roma";
            //P2.Año=2018;
            //P2.Pais="México";
            //P2.Director="Alfonso cuarón";
            //Console.WriteLine( "Pelicula ganadora al oscar: "+ P2.Titulo +"\nAño: " +P2.Año );




        }
    }
}
