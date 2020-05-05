using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TrashVanish
{
    internal class Worker
    {
        public static void RunVanisher(string cwd, List<RuleModel> rules)
        {
            foreach (RuleModel rule in rules)
            {
                //   MessageBox.Show(rule.ruleExtension);
                Thread thread = new Thread(new ThreadStart(() => Work(cwd, rule.ruleExtension, rule.rulePath)));
                thread.Start();
            }
        }

        private static void Work(string cwd, string extension, string targetpath)
        {
            string[] files = Directory.GetFiles(cwd, "*" + extension);
            if (files.Length < 1)
            {
                return;
            }
            if (!Directory.Exists(targetpath))
            {
                Directory.CreateDirectory(targetpath);
            }
            foreach (string file in files)
            {
                string destination = Path.Combine(targetpath, Path.GetFileName(file));
                if (!File.Exists(destination))
                {
                    File.Copy(file, destination, false);
                }
            }
            MessageBox.Show("Задача для \"" + extension + "\" завершена");
        }
    }
}