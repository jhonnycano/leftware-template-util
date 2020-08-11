using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Leftware.Utils.TemplateUtil
{
    public static class Utils
    {
        public static string RemoveFirstLines(string text, int linesCount)
        {
            var lines = Regex.Split(text, "\r\n|\r|\n").Skip(linesCount);
            return string.Join(Environment.NewLine, lines.ToArray());
        }

        public static string GetAppFolder(AppFolder appFolder)
        {
            var commonAppFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var folder = Path.Combine(commonAppFolder, "Leftware", "TemplateUtil", appFolder.ToString());
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
            return folder;
        }

        public static Icon GetIcon()
        {
            Icon appIcon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            return appIcon;
        }
    }
}
