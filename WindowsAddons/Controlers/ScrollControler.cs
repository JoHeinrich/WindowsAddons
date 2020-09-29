using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace VoiceControl
{

    public class ScrollController : ICommandControllerDefinition
    {
        public ScrollController() 
        {

        }

        public void Build(ICommandBuilder builder)
        {
            InputSimulator inputSimulator = new InputSimulator();
            builder.AddCommand("up", () => inputSimulator.Mouse.VerticalScroll(5))
            .AddCommand("up number()", x => inputSimulator.Mouse.VerticalScroll(x))
            .AddCommand("down", () => inputSimulator.Mouse.VerticalScroll(-5))
            .AddCommand("down number()", x => inputSimulator.Mouse.VerticalScroll(-x));
     
        }

        int ScrollDirection = 0;

        public string Name => "scroll";

        public async Task PerformScrolling()
        {
            InputSimulator inputSimulator = new InputSimulator();
            do
            {
                inputSimulator.Mouse.VerticalScroll(ScrollDirection);
                await Task.Delay(1000);
            } while (ScrollDirection != 0);
        }
        public void StartScrolling(int direction)
        {
            if (ScrollDirection == 0)
            {
                PerformScrolling();
            }
            ScrollDirection = direction;

        }

        
    }

}
