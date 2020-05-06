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
        public static void RunVanisher(string cwd, List<RuleModel> rules, bool deleteFile, bool owFiles)
        {
            foreach (RuleModel rule in rules)
            {
                Thread thread = new Thread(new ThreadStart(() => Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles)));
                thread.Start();
            }
        }

        private static void Work(string cwd, string extension, string includes, string targetpath, bool deleteFile, bool owFiles)
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
                string filename = Path.GetFileName(file);
                string destination = Path.Combine(targetpath, filename);

                if (filename.Contains(includes))
                {
                    if (File.Exists(destination) & !owFiles)
                    {
                        MessageBox.Show("Файл " + filename + " уже существет в " + targetpath);
                        continue;
                    }
                    File.Copy(file, destination, owFiles);
                    if (deleteFile)
                    {
                        File.Delete(file);
                    }
                }
            }
            MessageBox.Show("Задача для \"" + extension + "\" завершена");
        }
    }
}