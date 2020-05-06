using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TrashVanish
{
    internal class Worker
    {
        private RichTextBox rtb;

        public Worker(Form mw)
        {
            rtb = mw.Controls.Find("logRTB", true).FirstOrDefault() as RichTextBox;
        }

        public void RunVanisher(string cwd, List<RuleModel> rules, bool deleteFile, bool owFiles)
        {
            foreach (RuleModel rule in rules)
            {
                new Thread(new ThreadStart(() => Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles))).Start();
                rtb.AppendText("TaskStarted\r\n");
            }
        }

        private void Work(string cwd, string extension, string includes, string targetpath, bool deleteFile, bool owFiles)
        {
            Action action = () =>
            {
                rtb.AppendText("Задача завершена");
            };
            string[] files = Directory.GetFiles(cwd, "*" + extension);
            if (files.Length < 1)
            {
                if (rtb.InvokeRequired)
                {
                    rtb.Invoke(action);
                }
                else
                {
                    action();
                }
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
            if (rtb.InvokeRequired)
            {
                rtb.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}