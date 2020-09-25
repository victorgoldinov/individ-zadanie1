using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public partial class AddEditOtdel : Form
    {
        public AddEditOtdel()
        {
            InitializeComponent();
        }

        private void AddEditOtdel_Load(object sender, EventArgs e)
        {

        }

        private void AddEditOtdel_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass.mainForm.Enabled = true;
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "Add":
                    MainClass.AddOtdel(otdel_txbx.Text);
                    this.Close();
                    break;
                case "Edit":
                    MainClass.EditOtdel(otdel_txbx.Text);
                    this.Close();
                    break;
            }
        }
    }
}
