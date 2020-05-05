using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            MessageBox.Show("For " + extension + " " + files.Length + " files were found");
            foreach (string file in files)
            {
                string destination = Path.Combine(targetpath, Path.GetFileName(file));
                File.Copy(file, destination, false);
            }
            MessageBox.Show("Task Done");
        }
    }
}