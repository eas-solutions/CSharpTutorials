using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SQLiteConnectionDemo_WinForms
{
    public partial class Form1 : Form
    {
        private string databaseName = "test.db";

        public Form1()
        {
            InitializeComponent();
        }

        // Button Commands

        #region btn_CreateDatabase_Click

        /// <summary>   Event handler. Called by btn_CreateDatabase for click events. </summary>
        /// <remarks>   A Beging, 19.08.2021. </remarks>
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        private void btn_CreateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new SqliteConnection(GetConnectionString());
                connection.Open();

                // Create SQL Command
                var command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE users ( id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(20), age INTEGER )";

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region btn_Drop_Click

        /// <summary>   Event handler. Called by btn_Drop for click events. </summary>
        /// <remarks>   A Beging, 19.08.2021. </remarks>
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        private void btn_Drop_Click(object sender, EventArgs e)
        {
            try
            {
                // Simply remove file, SQLite doesn't support the DROP DATABASE command
                File.Delete(databaseName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region btn_Read_Click

        /// <summary>   Event handler. Called by btn_Read for click events. </summary>
        /// <remarks>   A Beging, 19.08.2021. </remarks>
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        private void btn_Read_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new SqliteConnection(GetConnectionString());
                connection.Open();

                // Create SQL Command
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM users";
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    listBoxUsers.Items.Clear();

                    while (reader.Read())
                    {
                        var name = reader.GetString(1);
                        var age = reader.GetInt32(2);

                        // "Name: Max, Age: 27"
                        var text = $"Name: {name}, Age: {age}";

                        listBoxUsers.Items.Add(text);
                    }
                }

                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region btn_Insert_Click

        /// <summary>   Event handler. Called by btn_Insert for click events. </summary>
        /// <remarks>   A Beging, 19.08.2021. </remarks>
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate name
                var name = txtBoxName.Text;
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Name cannot be empty");
                    return;
                }

                // Validate age
                if (!int.TryParse(txtBoxAge.Text, out var age))
                {
                    MessageBox.Show("Invalid age entered");
                    return;
                }

                var connection = new SqliteConnection(GetConnectionString());
                connection.Open();

                // Create SQL Command
                var command = connection.CreateCommand();
                command.CommandText = $"INSERT INTO users (name, age) VALUES ('{name}', {age});";
                command.ExecuteNonQuery();

                // Simulate the "READ DATA" click programmatically
                btn_Read.PerformClick();

                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion
        
        // Internal Methods

        #region GetConnectionString

        /// <summary>   Gets connection string. </summary>
        /// <remarks>   A Beging, 19.08.2021. </remarks>
        /// <returns>   The connection string. </returns>
        private string GetConnectionString()
        {
            return "Data Source=" + databaseName;
        }

        #endregion
    }
}
