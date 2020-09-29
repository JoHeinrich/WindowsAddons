using WindowsInput;
namespace VoiceControl
{
    public class FloatController : AutoController
    {


        public override void Build(ICommandBuilder builder)
        {
            base.Build(builder);

            builder
             .AddCommand("up", () => StartScrolling(1))
             .AddCommand("down", () => StartScrolling(-1));

        }

        public void StartScrolling(int direction)
        {
            InputSimulator inputSimulator = new InputSimulator();

            Start(() => inputSimulator.Mouse.VerticalScroll(direction));

        }
    }

}
