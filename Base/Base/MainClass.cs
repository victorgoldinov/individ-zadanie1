using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Base
{
    public static class MainClass
    {
        public static SqlConnection sqlConnection;
        public static mainForm @mainForm;
        
        //Открытие соединения
        public static void OpenConnection()
        {
            string connectionString1 = @"Data Source=.\SQLEXPRESS; Initial Catalog = contingent; Integrated Security = True";
            //string connectionString1 = String.Format(@"Data Source=.\SQLEXPRESS;AttachDbFilename={0}\contingent.mdf; Integrated Security = True", Application.StartupPath);
            sqlConnection = new SqlConnection(connectionString1);
            
            sqlConnection.Open();
        }

        //Закрытие
        public static void CloseConnection() 
        {
            //sqlConnection.Close();
           /* SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = MainClass.sqlConnection;
            addCommand.CommandType = CommandType.Text;
            string sqlComm = String.Format("sp_detach_db  @dbname={0}\\contingent.mdf;", Application.StartupPath.ToString());

            addCommand.CommandText = sqlComm;
            addCommand.ExecuteNonQuery();*/
        }
        public static void AddOtdel(string otdelName) 
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = sqlConnection;
            string sqlCommand = String.Format("INSERT INTO [otdel] Values ('{0}')", otdelName);

            myCommand.CommandText = sqlCommand;
            myCommand.ExecuteNonQuery();
            mainForm.LoadOtdels();
        }
        public static void EditOtdel(string otdelName)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = sqlConnection;
            string sqlCommand = String.Format("UPDATE [otdel] set otdel_name='{0}' Where ID_otdel={1}", otdelName, Convert.ToInt32(mainForm.otdelView.CurrentRow.Cells[0].Value));

            myCommand.CommandText = sqlCommand;
            myCommand.ExecuteNonQuery();
            mainForm.LoadOtdels();
        }
    }

}
