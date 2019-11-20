using System;

namespace Cola
{
	public class Cola < T >
	{
		readonly int Tamaño;
		int c_puntero = 0;
		T[] Items;
		public Cola() : this(100){}
		public Cola(int Tam)
		{
			Tamaño = Tam;
			Items = new T[Tamaño];
		}
		public void Push(T item)
		{
			if (c_puntero >= Tamaño)
				throw new StackOverflowException();
			Items[c_puntero] = item;
			c_puntero++;
		}
		public T Pop()
		{			
			if (c_puntero > 0)
			{
				T item=Items[0];
				for (int i=1; i < c_puntero; i++)
				{
					Items[i-1]=Items[i];					
				}
				c_puntero--;
				return item;
			}
			else
			{
				c_puntero = 0;
				throw new InvalidOperationException("Stack vacio");
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Cola<string> Lista = new Cola<string>(3);
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