using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 1000).Select(x => x == 2 || x == 3 || (x % 2 != 0 && x != 1 && !Enumerable.Range(3, x / 2).Select(y => x % 2 == 0 || x % y != 0 ? null : "false").Contains("false")) ? x + "\n" : "").ToList().ForEach(i => Console.Write(i));
            Enumerable.Range(1, 1000).Select(x => x == 2 || x == 3 || (x%2!=0 && x != 1 && !Enumerable.Range(3, x/2).Select(y => x%2==0||x % y != 0 ? null : "false").Contains("false")) ? x + "\n" : "").ToList().ForEach(i => Console.Write(i));
            Console.ReadLine();
        }
    }
}
