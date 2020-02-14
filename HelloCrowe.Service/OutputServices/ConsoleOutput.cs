using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCrowe.Service
{
    public class ConsoleOutput : OutputService
    {
        public override void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
