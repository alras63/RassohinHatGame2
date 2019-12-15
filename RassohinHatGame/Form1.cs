using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RassohinHatGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void H1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminlogin = new AdminForm();
            adminFormData adminFormData = new adminFormData();
            if(adminlogin.ShowDialog() == DialogResult.OK)
            {
                adminFormData.Show();
            }
         
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();

            gameForm.Show();
        }
    }
}
