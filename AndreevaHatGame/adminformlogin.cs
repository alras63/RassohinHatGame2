using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreevaHatGame
{
    public partial class AdminForm : Form
    {
        Users userClass = new Users();

        List<User> users = new List<User>();


        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            users = userClass.getListOfUsers();

            var login = loginBox.Text;
            var password = passwordBox.Text;

            User userLogin = new User { Login = login, Password = password};
            if(users.Contains(userLogin))
            {
                var user = users.Where(userS => userS.Login == login).ToList();
                if(user[0].Password == password)
                {
                 
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } else
                {
                    MessageBox.Show("Ошибка пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Пользователь с такими данными не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
