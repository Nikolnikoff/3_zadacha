using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace _3_zadacha
{
    class DataBase
    {       
        //подключение к БД
        SqlConnection sqlСonnection = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=Test_db;Integrated Security=True");

        public void openConnection()
        {
            if (sqlСonnection.State == System.Data.ConnectionState.Closed)
            {
                sqlСonnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlСonnection.State == System.Data.ConnectionState.Open)
            {
                sqlСonnection.Close();
            }
        }
        public SqlConnection getSqlConnection()
        {
            return sqlСonnection;
        }
    }
}
