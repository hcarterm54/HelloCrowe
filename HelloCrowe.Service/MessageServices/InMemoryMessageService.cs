using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCrowe.Service
{
    public class InMemoryMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello World";
        }
    }
}
