using System;
using System.Threading;

namespace SharedResources
{
    class Program
    {
		private static bool isCompleted;
		static readonly object lockCompleted = new object();
        static void Main(string[] args)
        {
            Thread thread = new Thread(HelloWorld);
			thread.Start();

			HelloWorld();
        }

		private static void HelloWorld()
		{
			lock(lockCompleted)
			{
				if(!isCompleted)
				{
					Console.WriteLine("Hello world should be printed just once");
					isCompleted = true;
				}
			}
		}
    }
}
