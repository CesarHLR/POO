using System;

namespace Domino
{
    class Domino
    {
        public  int A;
        public  int B;
        
        public Domino(int a,int b)
        {
         A=a;
         B=b;
        }
        public static int operator +(Domino d1, Domino d2)
        {
        return  (d1.A+d2.A+d1.B+d2.B);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Domino a=new Domino (2,0);
            Domino b=new Domino(4,1);
            Console.WriteLine(a+b);
        }
    }
}
