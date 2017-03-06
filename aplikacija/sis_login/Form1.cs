using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sis_login
{
    public partial class Form1 : Form
    {
        public string givenUsername = "";
        public string givenPassword = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            User currentUser = new User();
            givenUsername = textBox_username.Text;
            givenPassword = textBox_password.Text;
            if (currentUser.login(givenUsername, givenPassword) == null)
            {
                textBox_password.Clear();
                textBox_password.Focus();
                MessageBox.Show("Incorrect username or password!", "Login info");
            }
            else {
                textBox_username.Clear();
                textBox_password.Clear();
                textBox_username.Focus();
                MessageBox.Show("Successful login!", "Login info");
            }

        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                button_login_Click(sender, null);
            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            textBox_username.Clear();
            textBox_password.Clear();
            textBox_username.Focus();
            FrmRegister register = new FrmRegister();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_username.Clear();
            textBox_password.Clear();
            textBox_username.Focus();
            FrmRetrievePassword retrieve = new FrmRetrievePassword();
            retrieve.ShowDialog();
        }
    }
}
