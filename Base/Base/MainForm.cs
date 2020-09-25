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
using System.Data;

namespace Base
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void openConnection_Click(object sender, EventArgs e)
        { 

        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            MainClass.@mainForm = this; 
            MainClass.OpenConnection();
            LoadOtdels();
           /* LoadGroups();
            LoadStudents();*/
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass.CloseConnection();
        }
        public void LoadOtdels()
        {
            otdelView.Rows.Clear();
            string command = "SELECT * from [otdel]";
            SqlCommand loadData = new SqlCommand(command, MainClass.sqlConnection);
            loadData.CommandType = CommandType.Text;
            SqlDataReader reader = loadData.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }
            foreach (string[] s in data)
                otdelView.Rows.Add(s);
            reader.Close();
            LoadGroups();
        }

        public void LoadGroups()
        {
            LoadGroups(Convert.ToInt32(otdelView.Rows[0].Cells[0].Value));
        }
        public void LoadGroups(int code)
        {
            groupsView.Rows.Clear();
            string command = String.Format("SELECT * from [groups] where otdel_code={0}", code);
            SqlCommand loadData = new SqlCommand(command, MainClass.sqlConnection);
            loadData.CommandType = CommandType.Text;
            SqlDataReader reader = loadData.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            foreach (string[] s in data)
                groupsView.Rows.Add(s);
            reader.Close();
            LoadStudents();
        }
        public void LoadStudents()
        {
            LoadStudents(Convert.ToInt32(groupsView.Rows[0].Cells[0].Value));
        }
        public void LoadStudents(int code) 
        {
            studentsView.Rows.Clear();
            string command = String.Format("SELECT * from [students] where group_code={0}", code);
            SqlCommand loadData = new SqlCommand(command, MainClass.sqlConnection);
            loadData.CommandType = CommandType.Text;
            SqlDataReader reader = loadData.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            foreach (string[] s in data)
                studentsView.Rows.Add(s);
            reader.Close();

        } 
        private void otdelView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGroups(Convert.ToInt32(otdelView.CurrentRow.Cells[0].Value));
        }

        private void groupsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadStudents(Convert.ToInt32(groupsView.CurrentRow.Cells[0].Value));
        }
        void AddOtdel(object sender, EventArgs e) 
        {
            Form addOtdel = new AddEditOtdel();
            addOtdel.Tag = "Add";
            addOtdel.Text = "Добавление отдела";
            addOtdel.Show();
            MainClass.@mainForm.Enabled = false;
        }
        void EditOtdel(object sender, EventArgs e)
        {
            AddEditOtdel addOtdel = new AddEditOtdel();
            addOtdel.Tag = "Edit";
            addOtdel.Text = "Изменение отдела";
            addOtdel.Show();
            addOtdel.otdel_txbx.Text = otdelView.CurrentRow.Cells[1].Value.ToString();
            MainClass.@mainForm.Enabled = false;
        }

        private void delOtdelBtn_Click(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = MainClass.sqlConnection;
            string sqlCommand = String.Format("DELETE FROM [otdel] WHERE ID_otdel={0}", Convert.ToInt32(otdelView.CurrentRow.Cells[0].Value)); ;
            myCommand.CommandText = sqlCommand;
            myCommand.ExecuteNonQuery();
            MainClass.mainForm.LoadOtdels();
        }
    }
}
