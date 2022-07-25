using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _3_zadacha
{
    public partial class FormDB : Form
    {
        DataBase dataBase = new DataBase();
        
        public FormDB()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Closing += ExecuteOnClosing;
        }
        private void CreateTable()
        {
            dtv_db.Columns.Add("id", "id");
            dtv_db.Columns.Add("flag", "флаг");
            dtv_db.Columns.Add("data", "Текст");
        }

        private void FormRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }
        //вывод данных с бд
        private void outData(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryStr = $"SELECT * FROM example";
            SqlCommand com = new SqlCommand(queryStr, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                FormRow(dgv, reader);
            }
            reader.Close();
        }
        //оновление даннных
        private async void GetDv()
        {
            Func<Task> testFunc = async () =>
            {                
                outData(dtv_db);
                //задержка на 1 секунду обновления
                await Task.Delay(1000);
            };
            while (true)
            {
                await testFunc();
            }
        }
        //загрузка формы
        private void FormDB_Load(object sender, EventArgs e)
        {
            CreateTable();
            outData(dtv_db);
            GetDv();
        }
        //нажатие кнопки СТОП
        private void button_obn_Click(object sender, EventArgs e)
        {
            dataBase.closeConnection();
            MessageBox.Show("Закрыто соединение с сервером БД", "Прекращение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //закрытие формы
        void ExecuteOnClosing(object sender, CancelEventArgs e)
        {            
            dataBase.closeConnection();
            MessageBox.Show("Закрыто соединение с сервером БД", "Прекращение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
