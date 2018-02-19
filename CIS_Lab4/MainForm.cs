using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace CIS_Lab4
{
    public partial class MainForm : Form
    {
        public string strconn;
        public NpgsqlConnection cnn = new NpgsqlConnection();

        public MainForm()
        {
            InitializeComponent();
        }

        private void запросСПараметромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionUpdate();
            cnn.ConnectionString = strconn;
                cnn.Open();
                string stsql = "";
                using (NpgsqlCommand myCommand = new NpgsqlCommand("select * from \"Жанры\" where \"Имя\" like :value1", cnn))
                {
                    myCommand.Parameters.Add(new NpgsqlParameter("value1",
                        NpgsqlTypes.NpgsqlDbType.Varchar));
                    stsql = "%" + commandTextBox.Text + "%";
                    myCommand.Parameters[0].Value = stsql;
                    using (NpgsqlDataReader dr = myCommand.ExecuteReader())
                    {
                        commandListBox.Items.Clear();
                        while (dr.Read())
                        {
                            commandListBox.Items.Add(Convert.ToString(dr[1]));
                        }
                    }
                }
                cnn.Close();
            }

        private void ConnectionUpdate()
        {
            this.strconn =
                $"Server={this.serverTextBox.Text};Port={this.portTextBox.Text};UserID={this.userTextBox.Text};Password={this.passwordTextBox.Text};Database={this.baseTextBox.Text}";
        }

        private void запросБезПараметраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionUpdate();
            cnn.ConnectionString = strconn;
            cnn.Open();
            string stsql = "";
            stsql = "select * from \"Жанры\" where \"Имя\" like \'%" +
                    commandTextBox.Text +
                    "%\';";
            using (NpgsqlCommand myCommand = new NpgsqlCommand(stsql, cnn))
            {
                using (NpgsqlDataReader dr = myCommand.ExecuteReader())
                {
                    commandListBox.Items.Clear();
                    while (dr.Read())
                    {
                        commandListBox.Items.Add(Convert.ToString(dr[1]));
                    }
                }
            }
            cnn.Close();

        }

        private void скалярнаяФункцияСПараметромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionUpdate();
            cnn.ConnectionString = strconn;
            cnn.Open();
            try
            {
                NpgsqlCommand myCommand = new NpgsqlCommand("myfunc", cnn);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.Add(new NpgsqlParameter());
                myCommand.Parameters[0].NpgsqlDbType = 
                    NpgsqlTypes.NpgsqlDbType.Integer;
                myCommand.Parameters[0].Value = 4;

                myCommand.Parameters.Add(new NpgsqlParameter());
                myCommand.Parameters[1].NpgsqlDbType =
                    NpgsqlTypes.NpgsqlDbType.Integer;
                myCommand.Parameters[1].Value = 5;

                myCommand.Parameters.Add(new NpgsqlParameter());
                myCommand.Parameters[2].NpgsqlDbType =
                    NpgsqlTypes.NpgsqlDbType.Integer;
                myCommand.Parameters[2].Direction =
                    ParameterDirection.Output;

                var result = myCommand.ExecuteScalar();
                MessageBox.Show(Convert.ToString(myCommand.Parameters[2].Value));
            }
            finally
            {
                cnn.Close();
            }
        }

        private void генерацияMacадресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionUpdate();
            cnn.ConnectionString = strconn;
            cnn.Open();
            try
            {
                var temp = new NpgsqlCommand {
                    Connection = cnn,
                    CommandText = 
                        $@"INSERT INTO mac_address(value) SELECT * FROM generate_random_mac('{MacGenerator.GenerateFirstOctetInMask(maskTextBox.Text).ToLower()}',{Convert.ToInt32(commandTextBox.Text)}) AS (a macaddr);"
                    
                };
                var myCommand = new NpgsqlCommand();
                myCommand.Connection = cnn;
                myCommand.CommandText =
                    "INSERT INTO mac_address(value) SELECT * FROM generate_random_mac(\'" +
                    MacGenerator.GenerateFirstOctetInMask(maskTextBox.Text).ToLower() + "\'," +
                    Convert.ToInt32(commandTextBox.Text) + ") AS (a macaddr);";
                myCommand.ExecuteNonQuery();
                

                MessageBox.Show("Генерация выполнена успешно!",
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw;
                MessageBox.Show("Возникла ошибка соединения, либо не указано количество mac-адресов",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
