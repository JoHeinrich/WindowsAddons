using System;
namespace VoiceControl
{
    public abstract class AutoController : INamedCommandController
    {

        AutoExecuter autoExecuter = new AutoExecuter();
     

        public abstract string Name { get; }

       
        public void Start(Action action)
        {
            autoExecuter.Start(action);
       

        }

        public virtual void Build(IBuilder builder)
        {
           builder.Commands. AddCommand("stop", () => autoExecuter.Stop());

        }
    }

}
