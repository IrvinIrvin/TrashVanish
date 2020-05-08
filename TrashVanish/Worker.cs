using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashVanish
{
    internal class Worker
    {
        private RichTextBox box;

        public Worker(Form mw)
        {
            box = mw.Controls.Find("logRTB", true).FirstOrDefault() as RichTextBox;
        }

        private List<string> affectedFiles = new List<string>();

        /// <summary>
        /// Запускает потоки для каждой задачи
        /// </summary>
        /// <param name="cwd">Текущая рабочая директория (рабочий стол)</param>
        /// <param name="rules">Список правил</param>
        /// <param name="deleteFile">Флаг удаления файлов после копирования</param>
        /// <param name="owFiles">Флаг перезаписи файлов если уже есть в конечной директории</param>
        async public void RunVanisher(string cwd, List<RuleModel> rules, bool deleteFile, bool owFiles)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            logger("Старт", Color.Lime);
            int includesCount = 0;
            List<RuleModel> complexRules = new List<RuleModel>();
            List<RuleModel> simpleRules = new List<RuleModel>();
            List<Task> tasks = new List<Task>();
            foreach (RuleModel rule in rules)
            {
                if (rule.ruleIncludes != "")
                {
                    includesCount++;
                    complexRules.Add(rule);
                }
                else
                {
                    simpleRules.Add(rule);
                }
            }
            foreach (RuleModel rule in complexRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
            logger("Задачи с комплексными правилами завершены", Color.MediumSpringGreen);
            tasks.Clear();
            foreach (RuleModel rule in simpleRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles);
                }));
            }
            await Task.WhenAll(tasks.ToArray());

            watch.Stop();
            logger("Все задачи завершены за " + watch.ElapsedMilliseconds + " миллисекунд", Color.Lime);
        }

        private void Work(string cwd, string extension, string includes, string targetpath, bool deleteFile, bool owFiles)
        {
            int filesCopied = 0;
            int errors = 0;
            string[] files = Directory.GetFiles(cwd, "*" + includes + "*" + extension);
            if (files.Length < 1)
            {
                if (includes != "")
                {
                    logger("Нет файлов для задачи \"" + extension + "\" + \"" + includes + "\"... сворачиваюсь", Color.DarkOrange);
                }
                else
                {
                    logger("Нет файлов для задачи \"" + extension + "\"... сворачиваюсь", Color.DarkOrange);
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
                        logger("Файл \"" + filename + "\" уже существет в \"" + targetpath + "\"... пропускаю", Color.Gold);
                        continue;
                    }
                    if (notAffected(file))
                    {
                        File.Copy(file, destination, owFiles);
                        affectedFiles.Add(file);
                    }
                    else
                    {
                        continue;
                    }
                    filesCopied++;
                    if (deleteFile)
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception e)
                        {
                            logger(e.Message, Color.Maroon);
                            errors++;
                        }
                    }
                }
            }
            if (errors != 0)
            {
                logger("Не все файлы \"" + extension + "\" перемещенны успешно", Color.OrangeRed);
            }
            else
            {
                if (includes != "")
                {
                    logger("Задача для \"" + extension + "\" \"" + includes + "\" завершилось успешно. Перемещенно файлов: " + filesCopied, Color.Lime);
                }
                else
                {
                    logger("Задача для \"" + extension + "\" завершилось успешно. Перемещенно файлов: " + filesCopied, Color.Lime);
                }
            }
        }

        private bool notAffected(string file)
        {
            foreach (string affectedFile in affectedFiles)
            {
                if (file == affectedFile)
                {
                    return false;
                }
            }
            return true;
        }

        private void logger(string message, Color color)
        {
            Action action = () =>
            {
                box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;

                box.SelectionColor = color;
                box.AppendText("[" + DateTime.Now + "]" + " - " + message + "\r\n");
                box.SelectionColor = box.ForeColor;
            };
            if (box.InvokeRequired)
            {
                box.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}