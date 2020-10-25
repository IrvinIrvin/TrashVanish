using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashVanish.Classes
{
    internal class currentCulture
    {
        public static ResourceManager GlobalResourseManager { get; set; }

        public static void setLanguageForCurrentCulture()
        {
            bool localizationExists = false;
            DirectoryInfo directoryInWhichToSearch = new DirectoryInfo(Environment.CurrentDirectory);
            FileSystemInfo[] filesAndDirs = directoryInWhichToSearch.GetFileSystemInfos($"*{CultureInfo.CurrentUICulture.TwoLetterISOLanguageName}*");
            foreach (FileSystemInfo dirOrFile in filesAndDirs)
            {
                if (dirOrFile.GetType() == typeof(DirectoryInfo))
                {
                    localizationExists = true;
                    break;
                }
            }
            if (!localizationExists)
            {
                GlobalResourseManager = new ResourceManager($"TrashVanish.lang_en", Assembly.GetExecutingAssembly());
            }
            else
            {
                GlobalResourseManager = new ResourceManager($"TrashVanish.lang_{CultureInfo.CurrentUICulture.TwoLetterISOLanguageName}", Assembly.GetExecutingAssembly());
            }
            //string[] dirs = Directory.GetDirectories($"{Path.PathSeparator}")
            //if (File.Exists($"lang_{CultureInfo.CurrentUICulture.TwoLetterISOLanguageName}.resx"))
            //{
            //    GlobalResourseManager = new ResourceManager($"TrashVanish.lang_{CultureInfo.CurrentUICulture.TwoLetterISOLanguageName}", Assembly.GetExecutingAssembly());
            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            //}
        }
    }
}