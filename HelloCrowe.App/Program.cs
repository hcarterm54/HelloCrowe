using HelloCrowe.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCrowe.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceSelector selector = new ServiceSelector();

            IMessageService service = selector.SelectMessageService(ConfigurationManager.AppSettings["InMemoryMessageService"]);
            var message = service.GetMessage();

            OutputService output = selector.SelectOutput(ConfigurationManager.AppSettings["ConsoleOutput"]);
            output.Write(message);
        }
    }
}
