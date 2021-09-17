using System;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

			Employee employee = new Employee();
			employee.Name = "gui";
			employee.CompanyName = "guiria";
			
			ThreadPool.QueueUserWorkItem(
				new WaitCallback(displayEmployeeInfo), employee);

			var processorCount = Environment.ProcessorCount;
			ThreadPool.SetMaxThreads(processorCount*2, processorCount*2);

			int workerThreads = 0;
			int completionPortThreads = 0;
			ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);

			ThreadPool.SetMaxThreads(workerThreads*2, completionPortThreads*2);

			Console.WriteLine(workerThreads);
			Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

			Console.ReadKey();
        }

		private static void displayEmployeeInfo(object employee)
		{
			Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
			Employee emp = employee as Employee;
			Console.WriteLine("Person name is {0} and compamy name is:", emp.Name, emp.CompanyName);
		}
    }
}
