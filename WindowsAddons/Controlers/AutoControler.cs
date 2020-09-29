using System;
namespace VoiceControl
{
    public abstract class AutoController : ICommandControllerDefinition
    {

        AutoExecuter autoExecuter = new AutoExecuter();
           
        public void Start(Action action)
        {
            autoExecuter.Start(action);
       

        }

        public virtual void Build(ICommandBuilder builder)
        {
           builder.AddCommand("stop", () => autoExecuter.Stop());

        }
    }

}
