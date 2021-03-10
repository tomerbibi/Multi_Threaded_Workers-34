using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded_Workers_34_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> queue = new List<int>
            {
                4,
                6,
                7,
                4,
                9,
                8,
                23,
                37,
                2
            };
            Workers w = new Workers();
            w.Pull(queue);
            Console.ReadLine();
        }
    }
}
