using System;
namespace VoiceControl
{
    public abstract class AutoController : ICommandControllerDefinition
    {

        AutoExecuter autoExecuter = new AutoExecuter();
           
        public void Start(Action action,int interval = 300)
        {
            autoExecuter.Start(action,interval);
       

        }

        public virtual void Build(ICommandBuilder builder)
        {
           builder.AddCommand("stop", () => autoExecuter.Stop());

        }
    }

}
