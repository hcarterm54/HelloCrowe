using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCrowe.Service
{
    public abstract class OutputService
    {

        /// <summary>
        /// Output the supplied message <paramref name="msg"/>
        /// </summary>
        /// <param name="msg"></param>
        public abstract void Write(string msg);
    }
}
