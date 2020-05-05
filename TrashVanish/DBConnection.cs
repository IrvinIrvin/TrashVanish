using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
using System.Windows.Forms;

namespace TrashVanish
{
    public class DBConnection
    {
        public static List<RuleModel> LoadRules()
        {
            List<RuleModel> rules = new List<RuleModel>();
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
                        id = reader["id"] as string,
                        ruleExtension = reader["extension"] as string,
                        ruleIncludes = reader["includes"] as string,
                        rulePath = reader["path"] as string
                    });
                }
                connection.Close();
                return rules;
                // Почему-то не работает
                //var output = connection.Query<RuleModel>("select * from rulestable", new DynamicParameters());
                //return output.ToList();

            }
        }

        public static void AddRule (RuleModel rule)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into rulestable (extension, includes, path) values (@ruleExtension, @ruleIncludes, @rulePath)", rule);
                MessageBox.Show("Правило создано!");
            }
        }

        public static void DeleteRule()
        {
            // TODO delete row from db
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}