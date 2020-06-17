using System.Windows.Forms;
namespace VoiceControl
{
   public  class NumberContoler : INamedCommandController
    {
       

        public string Name => "number";

        public void Build(IBuilder builder)
        {
           builder.Commands. AddCommand("number()", x => SendKeys.SendWait(x.ToString()));
            //RepetitionCount = 5;

        }
    }
}
