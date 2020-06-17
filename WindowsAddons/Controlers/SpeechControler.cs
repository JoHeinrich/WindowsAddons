//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace VoiceControl
//{
//    public class SpeechController : INamedCommandController
//    {


//        public string Name => "speech";

//        public void Build(IBuilder builder)
//        {
//            builder.Settings.Unblockable = true;

//            builder.Commands.AddCommand("on", () => builder.GlobalState.Set("speech", "on"))
//            .AddCommand("off", () => builder.GlobalState.Set("speech", "off"));
//            //.AddCommand("reload", () => program.Build())
//            //.AddCommand("convert online", () => builder.GlobalState.Set("text converter", "online"))
//            //.AddCommand("convert offline", () => builder.GlobalState.Set("text converter", "offline"))
            
//            //.AddCommand("Add to start", () => WindowsHelper.SetStartup(true))
//            //.AddCommand("Remove From start", () => WindowsHelper.SetStartup(true));
//        }

//    }
//}
