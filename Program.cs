﻿using System;
using System.Threading;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteUsingNewThread);
			thread.Name = "Cazton Worker";
			thread.Start();
			Thread.CurrentThread.Name = "Cazton Main";
			for(int i=0; i<1000; i++)
			{
				Console.Write(" A"+i+" ");
			}
        }

		private static void WriteUsingNewThread()
		{
			for(int i=0; i<1000; i++)
			{
				Console.Write(" Z"+i+" ");
			}
		}
    }
}
