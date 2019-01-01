using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTimerStartTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Task[] taskArray = new Task[10];
            while (1 > 0)
            {
                for (int i = 0; i < taskArray.Length; i++)
                {
                    if (taskArray[i] == null || (taskArray[i] != null && taskArray[i].Status != TaskStatus.Running))
                    {
                        taskArray[i] = Task.Factory.StartNew(() => TaskTest(i, rand.Next(5, 100)));
                    }
                    else {
                        //Console.WriteLine(taskArray[i].Id + " is already running.");
                    }
                }
                Thread.Sleep(5 * 1000);
            }
            //Console.ReadLine();
        }

        static void TaskTest(int loopCounter, int delaytimerMilliSeconds)
        {
            try
            {
                Console.WriteLine("Loop Counter ID - " + loopCounter + " Thread ID - " + Thread.CurrentThread.ManagedThreadId + " waiting for - " + delaytimerMilliSeconds);
                Thread.Sleep(delaytimerMilliSeconds * 1000);
                Console.WriteLine("Loop Counter ID - " + loopCounter + " Thread ID - " + Thread.CurrentThread.ManagedThreadId + " waiting completed");
            }
            catch
            {
                throw;
            }
        }
    }
}
