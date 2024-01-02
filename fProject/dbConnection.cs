using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fProject
{
    internal class dbConnection
    {
        string connectionString = "server=127.0.0.1; user=root; database=task; password=";
        MySqlConnection mysqlconnection;

        public Boolean testConnection()
        {
            try
            {
                mysqlconnection = new MySqlConnection(connectionString);
                return true; 
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public int UserLogin(string username, string password)
        {
            // Your database connection string
            string connectionString = "server=127.0.0.1; user=root; database=task; password=";

            using (MySqlConnection mysqlconnection = new MySqlConnection(connectionString))
            {
                string selectQuery = "SELECT password FROM user WHERE userName = @Username";
                MySqlCommand cmnd = new MySqlCommand(selectQuery, mysqlconnection);

                cmnd.Parameters.AddWithValue("@Username", username);

                try
                {
                    mysqlconnection.Open();

                    using (MySqlDataReader reader = cmnd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User found, compare passwords
                            string storedPassword = reader.GetString("password");
                            if(storedPassword == password)
                            {
                                //return 0 if all was aright and the password mathces 
                                return 0; 
                            }
                        }
                        else
                        {
                            // User not found
                            return 1; 
                        }
                        //return 2 if the the user was not found 
                        return 2; 
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log or throw)
                    MessageBox.Show(ex.Message);
                    //return 3 if an unecpected error occured
                    return 3;
                }
            }
        }

        public bool AddTask(string title, string description, string date, int priority, bool status, string created_by, string owner_group = "")
        {
            using (MySqlConnection mysqlConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlConnection.Open();

                    // Assuming you have a 'tasks' table with columns: title, description, task_date, priority
                    string query = "INSERT INTO task (title, description, due_date, priority, status, created_by, owner_group ) VALUES (@Title, @Description, @Date, @Priority, 0, @Createdby, @OwnerGroup)";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Priority", priority);
                        cmd.Parameters.AddWithValue("@Createdby", created_by);
                        cmd.Parameters.AddWithValue("@OwnerGroup", owner_group); 

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log, show error message, etc.)
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        public ArrayList GetTasksByUserName(string userName)
        {
            ArrayList taskList = new ArrayList();

            using (MySqlConnection mysqlConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlConnection.Open();

                    string query = "SELECT * FROM tasks WHERE UserName = @UserName";
                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName); //the userName is the Caller ID

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming Task is a class with properties like Title, DueDate, Priority, etc.
                                Task task = new Task
                                {
                                    Title = reader["title"].ToString(),
                                    DueDate = DateTime.Parse(reader["due_date"].ToString()), // Assuming DueDate is a DateTime column
                                    Priority = Convert.ToInt32(reader["priority"]),
                                    // Add other properties as needed
                                };

                                taskList.Add(task);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log, show error message, etc.)
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return taskList;
        }
    }


}
