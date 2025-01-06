using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace _1C_copy
{
    internal class SQLAdapter
    {
        private string connectionString = "Server=138.124.20.243;Database=my_db;UserId=remote_user;Password=remote_password;";
        private MySqlConnection _connection;

        public SQLAdapter()
        {
            _connection = new MySqlConnection(connectionString);
        }

        // OpenConnection октрывает соеденние с базой данных
        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        // Закрытие соединения
        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        // Выполнение SELECT
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        // Выполнение INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            try
            {
                OpenConnection();
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return rowsAffected;
        }
    }
}
