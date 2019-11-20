using System;

namespace Stack
{
    public class Stack < T >
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
            if(pila >= tamaño)
            {
              throw new StackOverflowException();
            }
              items[pila]=item;
              pila++;      
        }
        public T Pop()
        {
            pila--;
            if(pila>=0)
            {
                return items[pila];
            }
            else
            {
                pila=0;
                throw new InvalidOperationException("Stack vacio");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Lista=new Stack<string>(3);
            Lista.Push("Cesar");
            Lista.Push(" ");
            Lista.Push("Lopez");
            for(int i = 0; i < 3; i++) 
            {
				Console.Write(Lista.Pop());
			}
        }
    }
}
