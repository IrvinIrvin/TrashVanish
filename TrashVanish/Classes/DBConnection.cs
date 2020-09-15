using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

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
                    string sqlcommand = "SELECT * FROM rulestable";
                    SQLiteCommand command = new SQLiteCommand(sqlcommand, connection);
                    command.Prepare();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rules.Add(new RuleModel
                        {
                            ruleID = Convert.ToString(reader["id"]),
                            ruleExtension = reader["extension"] as string,
                            ruleIncludes = reader["includes"] as string,
                            rulePath = reader["path"] as string
                        });
                    }
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
                try
                {
                    SQLiteConnection.CreateFile(@".\trashVanish.db");
                    using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                    {
                        connection.Open();
                        string sql = @"CREATE TABLE rulestable (
                                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                            extension TEXT NOT NULL,
	                            includes  TEXT,
	                            path  TEXT NOT NULL,
	                            register  INTEGER NOT NULL
                            )";
                        SQLiteCommand command = new SQLiteCommand(sql, connection);
                        command.ExecuteNonQuery();
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
                    cmd.CommandText = "insert into rulestable (extension, includes, path) values (@ruleExtension, @ruleIncludes, @rulePath)";
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@ruleExtension", rule.ruleExtension);
                    cmd.Parameters.AddWithValue("@ruleIncludes", rule.ruleIncludes);
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
        public static void DeleteRule(string ruleID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    SQLiteCommand sqlComm = connection.CreateCommand();
                    sqlComm.CommandText = "DELETE FROM rulestable WHERE id=@id;";
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

        public static bool isRuleExist(string extension, string includes)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand(connection);
                cmd.CommandText = "SELECT COUNT(id) FROM rulestable WHERE extension=@extension AND includes=@includes";
                cmd.Parameters.AddWithValue("@extension", extension);
                cmd.Parameters.AddWithValue("@includes", includes);
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
        public static void AddSet(string setName, List<string> extensionsSet)
        {
        }
    }
}