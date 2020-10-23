using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WindowsInput;

namespace VoiceControl
{
    public class MouseController : ICommandControllerDefinition
    {



        public void Build(ICommandBuilder builder)
        {
            InputSimulator inputSimulator = new InputSimulator();

            builder.AddCommand("click", () => inputSimulator.Mouse.LeftButtonClick())
            .AddCommand("select", () =>
            {
                inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                inputSimulator.Mouse.LeftButtonClick();
                inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);

            })
            .AddCommand("box", () =>
            {
                inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LMENU);
                inputSimulator.Mouse.LeftButtonClick();
                inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LMENU);
                inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);

            })
            .AddCommand("right click", () => inputSimulator.Mouse.RightButtonClick())
            .AddCommand("doubleclick", () => inputSimulator.Mouse.LeftButtonDoubleClick())
            .AddCommand("Start drag", () => inputSimulator.Mouse.LeftButtonDown())

            .AddCommand("Stop drag", () => inputSimulator.Mouse.LeftButtonUp());
        }
    }
}
