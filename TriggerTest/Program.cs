using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 5, (i) => {
                LogicApp.ManualTrigger trigger = new LogicApp.ManualTrigger(new LogicApp.ManualTriggerConfiguration());
                trigger.TriggerAction(Guid.NewGuid().ToString("N"), File.ReadAllBytes(@"C:\Canon\Toolbox\40COMUPD.EXE"));
            });
            Console.ReadKey();
        }
    }
}
