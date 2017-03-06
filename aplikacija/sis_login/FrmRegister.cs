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
    public partial class FrmRegister : Form
    {
        private string givenName = "";
        private string givenSurname = "";
        private string givenEmail = "";
        private string givenUsername = "";
        private string givenPassword = "";
        private string givenSQ = "";

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            givenName = textBox_reg_name.Text;
            givenSurname = textBox_reg_surname.Text;
            givenEmail = textBox_reg_email.Text;
            givenUsername = textBox_reg_username.Text;
            givenPassword = textBox_reg_password.Text;
            givenSQ = textBox_reg_sq.Text;
            User user = new User();

            if (user.exists(givenUsername) == true) {
                textBox_reg_username.Focus();
                MessageBox.Show("Given username already exists, pick another one!", "Warning");
            }
            else if (givenName.Length == 0 || givenSurname.Length == 0 || givenUsername.Length == 0
                || givenPassword.Length == 0 || givenSQ.Length == 0 || givenEmail.Length == 0)
            {
                MessageBox.Show("There are empty fields, please fill all of them!", "Warning");
            }
            else if(givenPassword.Length < 5)
            {
                textBox_reg_password.Focus();
                MessageBox.Show("Your password must be at least 5 characters long!", "Warning");
            }
            else {
                user.ime = givenName;
                user.prezime = givenSurname;
                user.email = givenEmail;
                user.tajnoPitanje = givenSQ;
                user.korisnickoIme = givenUsername;
                user.lozinka = givenPassword;
                user.register();

                MessageBox.Show("Successful registration!", "Registration info");
                this.Close();
            }
        }

        private void textBox_reg_sq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                button_reg_Click(sender, null);
            }
        }
    }
}
