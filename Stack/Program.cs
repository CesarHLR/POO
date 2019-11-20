using System;

namespace Stack
{
    public class Stack<T>
    {
        readonly int tamaño;
        int pila=0;
        T[] items;
        public Stack():this(100){}
        public Stack(int tam)
        {
            tamaño=tam;
            items=new T[tamaño];
        }
        public void Push(T item)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
