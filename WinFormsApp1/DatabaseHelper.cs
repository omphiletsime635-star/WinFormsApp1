using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=CyberBotDB;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void AddTask(string title, string desc, DateTime? reminder)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Tasks (Title, Description, ReminderDate) VALUES (@t, @d, @r)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@t", title);
                    cmd.Parameters.AddWithValue("@d", desc);
                    cmd.Parameters.AddWithValue("@r", reminder.HasValue ? reminder.Value : (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTasks()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT TaskID, Title, Description, ReminderDate, IsCompleted FROM Tasks";
                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void UpdateTaskStatus(int taskId, bool isCompleted)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Tasks SET IsCompleted = @c WHERE TaskID = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@c", isCompleted);
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTask(int taskId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Tasks WHERE TaskID = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
