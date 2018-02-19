using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace CIS_Lab4
{
    public partial class MainForm : Form
    {
        private string _connectionString;
        public NpgsqlConnection cnn = new NpgsqlConnection();

        public MainForm()
        {
            InitializeComponent();

            this.serverTextBox.TextChanged += this.TextBoxOnTextChanged;
            this.portTextBox.TextChanged += this.TextBoxOnTextChanged;
            this.userTextBox.TextChanged += this.TextBoxOnTextChanged;
            this.passwordTextBox.TextChanged += this.TextBoxOnTextChanged;
            this.baseTextBox.TextChanged += this.TextBoxOnTextChanged;

            this.ConnectionUpdate();
        }

        private void TextBoxOnTextChanged(object sender, EventArgs eventArgs) => this.ConnectionUpdate();

        private void запросСПараметромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.InvokeGatedConnectionCommand(delegate(NpgsqlConnection connection) {
                using (var command = new NpgsqlCommand(@"select * from ""Жанры"" where ""Имя"" like :value1", connection))
                {
                    command.Parameters.Add(new NpgsqlParameter("value1", NpgsqlTypes.NpgsqlDbType.Varchar));
                    var stsql = $"%{this.commandTextBox.Text}%";
                    command.Parameters[0].Value = stsql;
                    using (var dr = command.ExecuteReader())
                    {
                        this.commandListBox.Items.Clear();
                        while (dr.Read())
                            this.commandListBox.Items.Add(Convert.ToString(dr[1]));
                    }
                }
            });
        }

        private void InvokeGatedConnectionCommand(Action<NpgsqlConnection> func) {
            using (var connection = new NpgsqlConnection(this._connectionString)) {
                connection.Open();
                func(connection);
            }
        }

        private void ConnectionUpdate()
        {
            this._connectionString =
                $"Server={this.serverTextBox.Text};Port={this.portTextBox.Text};UserID={this.userTextBox.Text};Password={this.passwordTextBox.Text};Database={this.baseTextBox.Text}";
        }

        private void запросБезПараметраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = this._connectionString;
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
            cnn.ConnectionString = this._connectionString;
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
            cnn.ConnectionString = this._connectionString;
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
            catch (Exception)
            {
                //throw;
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
