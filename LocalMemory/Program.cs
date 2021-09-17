using System;
using System.Threading;

namespace LocalMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(PrintOneToThirty).Start();

			PrintOneToThirty();
        }

		private static void PrintOneToThirty()
		{
			for(int i=0; i<30; i++)
			{
				Console.Write(i + 1 + " ");
			}
		}
    }
}
