using System;
using System.Collections.Generic;
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
        public void RunVanisher(string cwd, List<RuleModel> rules, bool deleteFile, bool owFiles)
        {
            int includesCount = 0;
            /* TODO - запустить потоки с инклудами и дождаться их завершения
             * После них запустить потоки без инклудов.
             * Если поставлен флаг owFiles закидывать затронутые файлы с инклудами в список и проверять если их использовали
            */
            foreach (RuleModel rule in rules)
            {
                if (rule.ruleIncludes != "")
                {
                    includesCount++;
                }
            }
            Task[] rulesWithIncludes = new Task[includesCount - 1];

            int localindex = 0;
            foreach (RuleModel rule in rules)
            {
                if (rule.ruleIncludes != "")
                {
                    rulesWithIncludes[localindex] = Task.Factory.StartNew(() =>
                    {
                        Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles);
                    });
                }
            }

            Task.WhenAll(rulesWithIncludes);
            logger("Задания с инклудами завершены", Color.AliceBlue);

            //foreach (RuleModel rule in rulesWithIncludes)
            //{
            //    new Thread(new ThreadStart(() => Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles))).Start();
            //    logger("Задание для \"" + rule.ruleExtension + "\" началось rule with include", Color.Orange);
            //}

            // Работает с инклудами если включено удаление после копирования
            //foreach (RuleModel rule in rules)
            //{
            //    new Thread(new ThreadStart(() => Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles))).Start();
            //    logger("Задание для \"" + rule.ruleExtension + "\" началось", Color.Orange);
            //}
        }

        private void Work(string cwd, string extension, string includes, string targetpath, bool deleteFile, bool owFiles)
        {
            int filesCopied = 0;
            int errors = 0;
            string[] files = Directory.GetFiles(cwd, "*" + extension);
            if (files.Length < 1)
            {
                logger("Нет файлов для \"" + extension + "\"... сворачиваюсь", Color.DarkOrange);
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
                logger("Задание для \"" + extension + "\" завершилось успешно. Перемещенно файлов: " + filesCopied + ", Всего файлов: " + files.Length, Color.Lime);
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