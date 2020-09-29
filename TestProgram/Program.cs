using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VoiceControl;
using System.Threading;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.Load("WindowsAddons");

            var builder=new SpeechProgramBuilder();
            builder.GetConsoleSpeechProgram();
            //InformationManager informationManager = new InformationManager(new ValueCollection());
            Console.WriteLine("Ready");
            while (true) { Thread.Sleep(2000); }

        }
    }
}
