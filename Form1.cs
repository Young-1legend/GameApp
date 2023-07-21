using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> userCredentials;

        public Form1()
        {
            InitializeComponent();
            InitializeUserCredentials();
        }
        private void InitializeUserCredentials()
        {
            
            userCredentials = new Dictionary<string, string>
            {
                { "admin", "password" },
                { "user1", "123456" },
                { "user2", "qwerty" }
                
            };
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userNametextbox.Text;
            string password = passwordtextbox.Text;

            if (ValidateCredentials(username, password))
            {
                // Successful login, open the main form
                Form mainForm = new Form();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            if (userCredentials.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
