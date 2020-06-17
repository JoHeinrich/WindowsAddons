//using System;
//using System.Diagnostics;
//using System.Windows.Automation;

//namespace VoiceControl
//{
//    public class FirefoxInformationProvider : IInformationProvider
//    {


//        public static string GetFirefoxUrl(Process process)
//        {
//            if (process == null)
//                throw new ArgumentNullException("process");

//            if (process.MainWindowHandle == IntPtr.Zero)
//                return null;

//            AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
//            if (element == null)
//                return null;


//            element = element.FindFirst(TreeScope.Subtree,
//                  new AndCondition(
//                      new PropertyCondition(AutomationElement.NameProperty, "Mit Google suchen oder Adresse eingeben", PropertyConditionFlags.IgnoreCase),
//                      new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit)));


//            if (element == null)
//                return null;

//            return ((ValuePattern)element.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
//        }
//        public static string GetCurretURL()
//        {
//            Process process = WindowInformation.ForegroundProcess;
//            if (!process.ProcessName.Contains("firefox")) return string.Empty;
//            string url = GetFirefoxUrl(process);
//            if (url == null) return string.Empty;
//            return url;
//        }

      
//        public string Name => "browser_url";
//        public string Value => GetCurretURL();

//    }
//}
