using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using TrashVanish.Classes;

namespace TrashVanish
{
    public class DBConnection
    {
        /// <summary>
        /// Load all rules from database and create list of RuleModels
        /// </summary>
        /// <returns>list of RuleModels</returns>
        public static List<RuleModel> LoadRules()
        {
            List<RuleModel> rules = new List<RuleModel>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();
                    string sqlcommand = "SELECT * FROM rulesTable";
                    SQLiteCommand command = new SQLiteCommand(sqlcommand, connection);
                    command.Prepare();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rules.Add(new RuleModel
                        {
                            //ruleID = Convert.ToString(reader["id"]),
                            ruleID = Convert.ToString(reader["id"]),
                            ruleExtension = reader["extension"] as string,
                            ruleIncludes = reader["includes"] as string,
                            rulePath = reader["path"] as string,
                            ruleIsCaseSensetive = Convert.ToInt32(reader["isCaseSensetive"]),
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка при получении информации из БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rules;
        }

        /// <summary>
        /// Checks if database is exist. If not, creates new
        /// </summary>
        public static void CheckDB()
        {
            if (!File.Exists(@".\trashVanish.db"))
            {
                string[] sqlCreateCommands = { @"CREATE TABLE ""extensionSetsTable"" (
                                                ""id""    INTEGER NOT NULL UNIQUE,
                                                ""name""  TEXT NOT NULL UNIQUE,
                                                ""isCaseSensetive""   INTEGER NOT NULL,
                                                ""targetPath""    TEXT NOT NULL,
                                                PRIMARY KEY(""id"" AUTOINCREMENT)
                                            )",
                                                @"CREATE TABLE ""extensionsForSetsTable"" (
                                                ""id""    INTEGER NOT NULL UNIQUE,
                                                ""setNameId"" INTEGER NOT NULL,
                                                ""extension"" TEXT NOT NULL,
                                                ""includes""  TEXT NOT NULL,
                                                PRIMARY KEY(""id"" AUTOINCREMENT)
                                            )",
                                                @"CREATE TABLE ""rulesTable"" (
                                                ""id""    INTEGER NOT NULL UNIQUE,
                                                ""extension"" TEXT NOT NULL,
                                                ""includes""  TEXT,
                                                ""isCaseSensetive""   INTEGER NOT NULL,
                                                ""path""  TEXT NOT NULL,
                                                PRIMARY KEY(""id"" AUTOINCREMENT)
                                            )"};
                try
                {
                    SQLiteConnection.CreateFile(@".\trashVanish.db");
                    using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                    {
                        connection.Open();
                        foreach (string sqlCreateCommand in sqlCreateCommands)
                        {
                            SQLiteCommand command = new SQLiteCommand(sqlCreateCommand, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка при создании бд", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Adds rule in database
        /// </summary>
        /// <param name="rule">rule object</param>
        public static void AddRule(RuleModel rule)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = "insert into rulesTable (extension, includes, isCaseSensetive, path) values (@ruleExtension, @ruleIncludes, @isCaseSensetive, @rulePath)";
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@ruleExtension", rule.ruleExtension);
                    cmd.Parameters.AddWithValue("@ruleIncludes", rule.ruleIncludes);
                    cmd.Parameters.AddWithValue("@isCaseSensetive", rule.ruleIsCaseSensetive);
                    cmd.Parameters.AddWithValue("@rulePath", rule.rulePath);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка при добавлении значений в бд", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Deletes rules by their id
        /// </summary>
        /// <param name="ruleID">id of the rule</param>
        public static void DeleteRule(string ruleID) // TODO: Wrap in transaction
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    SQLiteCommand sqlComm = connection.CreateCommand();
                    sqlComm.CommandText = "DELETE FROM rulesTable WHERE id=@id;";
                    sqlComm.Parameters.AddWithValue("@id", ruleID);
                    connection.Open();
                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public static bool isRuleExist(string extension, string includes, int isCaseSensetive)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand(connection);
                cmd.CommandText = "SELECT COUNT(id) FROM rulesTable WHERE extension=@extension AND includes=@includes AND isCaseSensetive=@isCaseSensetive";
                cmd.Parameters.AddWithValue("@extension", extension);
                cmd.Parameters.AddWithValue("@includes", includes);
                cmd.Parameters.AddWithValue("@isCaseSensetive", isCaseSensetive);
                int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                return rowCount > 0;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// Добавляет setName в extesionsSetName (таблица, содержащая названия наборов), а extensionsSet в extensionsSetExtensions (таблица, содержащая расширение и id набора, к которому оно принадлежит)
        /// </summary>
        /// <param name="setName">Название набора</param>
        /// <param name="extensionsSet">Расширения входящие в набор</param>
        /// <param name="targetPath">Путь в который пойдут файлы набора</param>
        ///
        public static void AddSet(string setName, Dictionary<string, string> extensionsSet, string targetPath, int isCaseSensetive)
        {
            // add name to extesionsSetName
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                SQLiteTransaction transaction = connection.BeginTransaction();
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Transaction = transaction;
                    cmd.CommandText = "INSERT INTO extensionSetsTable (name, isCaseSensetive, targetPath) VALUES (@Name, @isCaseSensetive, @targetPath)";
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@Name", setName);
                    cmd.Parameters.AddWithValue("@isCaseSensetive", isCaseSensetive);
                    cmd.Parameters.AddWithValue("@targetPath", targetPath);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    int setID = (int)connection.LastInsertRowId;
                    cmd.CommandText = "INSERT INTO extensionsForSetsTable (setNameId, extension, includes) VALUES (@setNameId, @extension, @includes)";
                    cmd.Parameters.AddWithValue("@setNameId", setID);
                    foreach (KeyValuePair<string, string> extEntry in extensionsSet)
                    {
                        cmd.Parameters.AddWithValue("@extension", extEntry.Key);
                        cmd.Parameters.AddWithValue("@includes", extEntry.Value);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка при добавлении значений в бд", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception exRollBack)
                    {
                        MessageBox.Show(exRollBack.Message, "Ошибка при откатывании бд в прежнее состояние", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Loads all sets from database
        /// </summary>
        /// <returns></returns>
        public static List<SetModel> LoadSets()
        {
            List<SetModel> setsList = new List<SetModel>();
            List<setExtensionModel> extensionsList = new List<setExtensionModel>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM extensionSetsTable", connection))
                    {
                        SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            setsList.Add(new SetModel
                            {
                                setID = Convert.ToString(reader["id"]),
                                setName = reader["name"] as string,
                                targetPath = reader["targetPath"] as string,
                                isCaseSensetive = Convert.ToInt32(reader["isCaseSensetive"]),
                            });
                        }
                        reader.Close();
                        command.CommandText = "SELECT * FROM extensionsForSetsTable";
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            extensionsList.Add(new setExtensionModel
                            {
                                extensionID = Convert.ToString(reader["id"]),
                                setNameID = Convert.ToString(reader["setNameId"]),
                                extension = reader["extension"] as string,
                                includes = reader["includes"] as string,
                            });
                        }
                        reader.Close();
                        foreach (SetModel set in setsList) // This needs to be optimized
                        {
                            List<setExtensionModel> sortedExtensions = new List<setExtensionModel>();
                            foreach (setExtensionModel extension in extensionsList)
                            {
                                if (set.setID == extension.setNameID)
                                {
                                    sortedExtensions.Add(extension);
                                }
                            }
                            set.extensions = sortedExtensions;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка при получении информации о наборах из БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return setsList;
        }

        public static SetModel LoadSetByID(string id)
        {
            SetModel set = new SetModel();
            List<setExtensionModel> extensionsList = new List<setExtensionModel>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM extensionSetsTable WHERE id=@id", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            set.setID = id;
                            set.setName = reader["name"] as string;
                            set.targetPath = reader["targetPath"] as string;
                            set.isCaseSensetive = Convert.ToInt32(reader["isCaseSensetive"]);
                        }
                        reader.Close();
                        command.Parameters.Clear();
                        command.CommandText = "SELECT * FROM extensionsForSetsTable WHERE setNameId=@setNameId";
                        command.Parameters.AddWithValue("@setNameId", id);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            extensionsList.Add(new setExtensionModel
                            {
                                extensionID = Convert.ToString(reader["id"]),
                                setNameID = Convert.ToString(reader["setNameId"]),
                                extension = reader["extension"] as string,
                                includes = reader["includes"] as string,
                            });
                        }
                        reader.Close();
                        set.extensions = extensionsList;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка при получении информации о наборах из БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return set;
        }

        /// <summary>
        /// Deletes set by it's id
        /// </summary>
        /// <param name="setID">Id of set that needs to be deleted</param>
        public static void DeleteSet(string setID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand("DELETE FROM extensionSetsTable WHERE id=@setID", connection, transaction))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@setID", setID);
                            command.ExecuteNonQuery();
                            command.CommandText = "DELETE FROM extensionsForSetsTable WHERE setNameId=?";
                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Ошибка при удалении значений из бд", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception exRollBack)
                            {
                                MessageBox.Show(exRollBack.Message, "Ошибка при откатывании бд в прежнее состояние", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}