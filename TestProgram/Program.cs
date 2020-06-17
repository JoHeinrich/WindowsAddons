using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceControlCore;
using VoiceControl;
using System.Threading;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.Load("WindowsAddons");

            new ControllerTestProgram();
            InformationManager informationManager = new InformationManager(new ValueCollection());
            Console.WriteLine("Ready");
            while (true) { Thread.Sleep(2000); }

        }
    }
}
