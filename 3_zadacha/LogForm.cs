using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _3_zadacha
{
    public partial class LogForm : Form
    {
        DataBase dataBase = new DataBase();
        public LogForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            textBox_pass.PasswordChar = '*';
            textBox_log.MaxLength = 50;
            textBox_pass.MaxLength = 50;
        }
        private void btn_con_Click(object sender, EventArgs e)
        {
            //Тестовые данные user user
            var loginUser = textBox_log.Text;
            var passUser = textBox_pass.Text;          
            
            //запрос на подключение к БД
            string querystring = $"SELECT id_user, login_user, password_user FROM register WHERE login_user = '{loginUser}' AND password_user = '{passUser}'";
            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getSqlConnection());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            //Если существует такой аккаунт в БД
            if(table.Rows.Count==1)
            {
                FormDB formdb = new FormDB();
                this.Hide();
                formdb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Логин или пароль указаны не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_pass.Text = "";
            }

        }
    }
}
