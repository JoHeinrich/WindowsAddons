using WindowsInput;
namespace VoiceControl
{
    public class AutoScrollController : AutoController
    {
    

        public override string Name => "Float";

        public override void Build(IBuilder builder)
        {
            base.Build(builder);

            builder.Commands.AddCommand("up", () => StartScrolling(1))
             .AddCommand("down", () => StartScrolling(-1));

        }

        public void StartScrolling(int direction)
        {
            InputSimulator inputSimulator = new InputSimulator();

            Start(() => inputSimulator.Mouse.VerticalScroll(direction));

        }
    }

}
