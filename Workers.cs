using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_Workers_34_
{
    class Workers
    {
        private List<Task> tasks = new List<Task>(5);

        public void Pull(List<int> ints)
        {
            ints.ForEach(_ =>
            {
                if (tasks.Count < 6)
                    tasks.Add((Task.Run(() => Console.WriteLine(_ * 2))));
                else
                {
                    bool done = false;
                    while (!done)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if(tasks[i].IsCompleted)
                            {
                                tasks[i] = ((Task.Run(() => Console.WriteLine(_ * 2))));
                                done = true;
                                break;
                            }
                            if(i == 4)
                                Thread.Sleep(100);
                        }
                    }
                }
            });
        }

        public Workers()
        {
            
        }
    }
}
