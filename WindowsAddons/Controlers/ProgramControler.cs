
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
namespace VoiceControl
{
    public class ProgramController : ICommandControllerDefinition
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + "\\Programs";

        public void Build(ICommandBuilder builder)
        {
            var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).ToList();
            Dictionary<string, string> mapping = new Dictionary<string, string>();

            files.ForEach(x => mapping[Path.GetFileNameWithoutExtension(x)] = x);
            builder.AddCommand(mapping.Keys.ToList(), s =>
            {
                try
                {
                    Process.Start(mapping[s]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(mapping[s]);
                    Console.WriteLine(e);
                }
            });
            

        }
    }
}
