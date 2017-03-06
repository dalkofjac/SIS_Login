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
    public partial class FrmRetrievePassword : Form
    {
        private string givenUsername = "";
        private string givenEmail = "";
        private string givenPetName = "";

        public FrmRetrievePassword()
        {
            InitializeComponent();
        }

        private void button_retrieve_Click(object sender, EventArgs e)
        {
            givenUsername = textBox_username.Text;
            givenEmail = textBox_email.Text;
            givenPetName = textBox_pet.Text;
            User user = new User();

            string password = user.retrieve(givenUsername, givenEmail, givenPetName);

            if (password == "")
            {
                MessageBox.Show("Given information is incorrect!", "Warning");
            }
            else {
                MessageBox.Show("Your old password has been deleted. Your new password is: " + password, "Retrieve info");
                this.Close();
            }
        }

        private void textBox_pet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                button_retrieve_Click(sender, null);
            }
        }
    }
}
