using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VoiceControl
{
    class WindowsHelper
    {
    public static void SetStartup(bool runOnStart)
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            var AppName = Application.ProductName;
        if (runOnStart)
            rk.SetValue(AppName, Application.ExecutablePath);
        else
            rk.DeleteValue(AppName, false);

    }
}
}
