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
using TrashVanish.Classes;

namespace TrashVanish
{
    internal class Worker
    {
        private RichTextBox box;

        public Worker(RichTextBox richTextBox)
        {
            box = richTextBox;
        }

        private List<string> affectedFiles = new List<string>();

        /// <summary>
        /// Запускает потоки для каждой задачи
        /// </summary>
        /// <param name="cwd">Текущая рабочая директория (рабочий стол)</param>
        /// <param name="rules">Список правил</param>
        /// <param name="sets">Список наборов</param>
        /// <param name="deleteFile">Флаг удаления файлов после копирования</param>
        /// <param name="owFiles">Флаг перезаписи файлов если уже есть в конечной директории</param>
        async public void RunVanisher(string cwd, List<RuleModel> rules, List<SetModel> sets, bool deleteFile, bool owFiles)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            logger("Старт", Color.Lime);
            List<RuleModel> complexRules = new List<RuleModel>();
            List<RuleModel> simpleRules = new List<RuleModel>();
            List<Task> tasks = new List<Task>();
            foreach (RuleModel rule in rules)
            {
                if (rule.ruleIncludes != "")
                {
                    complexRules.Add(rule);
                }
                else
                {
                    simpleRules.Add(rule);
                }
            }
            List<RuleModel> caseSensitiveRules = new List<RuleModel>();
            List<RuleModel> caseInsensitiveRules = new List<RuleModel>();
            foreach (RuleModel rule in complexRules)
            {
                if (rule.ruleIsCaseSensetive == 1)
                {
                    caseSensitiveRules.Add(rule);
                    //complexRules.Remove(rule);// В комплексных правилах не останется правил с учетом регистра UPD нельзя удалять элементы кллекции по которой ходишь циклом
                }
                else
                {
                    caseInsensitiveRules.Add(rule);
                }
            }
            foreach (RuleModel rule in caseSensitiveRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles, rule.ruleIsCaseSensetive);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
            logger("Задачи, чувствительные к регистру, с комплексными правилами завершены", Color.MediumSpringGreen);
            tasks.Clear();
            foreach (RuleModel rule in caseInsensitiveRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles, rule.ruleIsCaseSensetive);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
            logger("Задачи с комплексными правилами завершены", Color.MediumSpringGreen);
            tasks.Clear();
            foreach (RuleModel rule in simpleRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles, rule.ruleIsCaseSensetive);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
            complexRules.Clear();
            simpleRules.Clear();
            logger("Задачи с правилами завершены", Color.MediumSpringGreen);
            tasks.Clear();
            foreach (SetModel set in sets)
            {
                foreach (setExtensionModel ext in set.extensions)
                {
                    if (ext.includes != "")
                    {
                        complexRules.Add(new RuleModel { ruleExtension = ext.extension, ruleIncludes = ext.includes, ruleIsCaseSensetive = set.isCaseSensetive, rulePath = set.targetPath });
                    }
                    else
                    {
                        simpleRules.Add(new RuleModel { ruleExtension = ext.extension, ruleIncludes = ext.includes, ruleIsCaseSensetive = set.isCaseSensetive, rulePath = set.targetPath });
                    }
                }
            }
            caseSensitiveRules.Clear();
            caseInsensitiveRules.Clear();

            foreach (RuleModel rule in complexRules)
            {
                if (rule.ruleIsCaseSensetive == 1)
                {
                    caseSensitiveRules.Add(rule);
                }
                else
                {
                    caseInsensitiveRules.Add(rule);
                }
            }

            foreach (RuleModel rule in caseSensitiveRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles, rule.ruleIsCaseSensetive);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
            logger("Задачи с наборами, чувствительными к регистру, с комплексными правилами завершены", Color.MediumSpringGreen);
            tasks.Clear();
            foreach (RuleModel rule in caseInsensitiveRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles, rule.ruleIsCaseSensetive);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
            logger("Задачи с наборами, с комплексными правилами, завершены", Color.MediumSpringGreen);
            tasks.Clear();
            foreach (RuleModel rule in simpleRules)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Work(cwd, rule.ruleExtension, rule.ruleIncludes, rule.rulePath, deleteFile, owFiles, rule.ruleIsCaseSensetive);
                }));
            }
            await Task.WhenAll(tasks.ToArray());
            logger("Задачи с простыми наборами завершены", Color.MediumSpringGreen);
            await Task.WhenAll(tasks.ToArray());
            watch.Stop();
            logger("Все задачи завершены за " + watch.ElapsedMilliseconds + " миллисекунд", Color.Lime);
        }

        private void Work(string cwd, string extension, string includes, string targetpath, bool deleteFile, bool owFiles, int isCaseSensetive)
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
                bool isContains = false;
                bool doNotDelete = false;
                string filename = Path.GetFileName(file);
                string destination = Path.Combine(targetpath, filename);

                if (isCaseSensetive == 1)
                {
                    if (filename.Contains(includes))
                    {
                        isContains = true;
                    }
                }
                else
                {
                    if (filename.ToLower().Contains(includes.ToLower()))
                    {
                        isContains = true;
                    }
                }
                if (isContains)
                {
                    if (File.Exists(destination) & !owFiles)
                    {
                        logger("Файл \"" + filename + "\" уже существет в \"" + targetpath + "\"... пропускаю", Color.Gold);
                        continue;
                    }
                    if (notAffected(file))
                    {
                        try
                        {
                            File.Copy(file, destination, owFiles);
                        }
                        catch (UnauthorizedAccessException uae)
                        {
                            logger(uae.Message + ". Чтобы скопировать файл в \"" + targetpath + "\" запустите программу от имени администратора", Color.Maroon);
                            errors++;
                            doNotDelete = true;
                        }
                        catch (Exception e)
                        {
                            logger(e.Message, Color.Maroon);
                            errors++;
                            doNotDelete = true;
                        }
                        affectedFiles.Add(file);
                    }
                    else
                    {
                        continue;
                    }
                    filesCopied++;
                    if (deleteFile)
                    {
                        if (!doNotDelete) // Если произошла ошибка при копировании - оставить оригинал
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