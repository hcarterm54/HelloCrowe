using HelloCrowe.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCrowe.App
{
    public class ServiceSelector
    {
        public IMessageService SelectMessageService(string serviceType)
        {
            IMessageService service;

            switch (serviceType)
            {
                case "ConsoleMessageService":
                    service = new ConsoleMessageService();
                    break;
                case "InMemoryMessageService":
                    service = new InMemoryMessageService();
                    break;
                case "MobileMessageService":
                    service = new MobileMessageService();
                    break;
                default:
                    service = new InMemoryMessageService();
                    break;
            }

            return service;
        }

        public OutputService SelectOutput(string outputType)
        {
            OutputService service;

            switch (outputType)
            {
                case "ConsoleMessageService":
                    service = new ConsoleOutput();
                    break;
                case "InMemoryMessageService":
                    service = new DbOutput();
                    break;
                case "MobileMessageService":
                    service = new FileOutput();
                    break;
                default:
                    service = new ConsoleOutput();
                    break;
            }


            return service;
        }
    }
}
