using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace VoiceControl
{
    public class CurrentWindowInformationProvider : IInformationSource
    {
        public string Name => "process_name";
        public string Value => WindowInformation.ForegroundProcess.ProcessName;

    }
    public class WindowTitleProvider : IInformationSource
    {
        public string Name => "window_title";
        public string Value => WindowInformation.GetActiveWindow();

    }
    public class WindowMaximizedProvider : IInformationSource
    {
        public string Name => "window_maximized";
        public string Value => WindowInformation.GetPlacement().ToString();

    }
 
}
