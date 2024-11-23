using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        

        private void loginB_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Visible = false;
        }





        private void showpassCK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpassCK.Checked)
            {
                passwordT.UseSystemPasswordChar = false;
            }
            else
            {
                passwordT.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupB_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name, pass;
                name = usernameT.Text.ToString().Trim();
                pass = passwordT.Text.ToString().Trim();
                usernameT.Text = name;
                passwordT.Text = pass;
                StreamWriter writer;
                writer = File.AppendText("D:\\Final_Project\\Inventory_Management_prototype1\\Files\\Accounts\\Saves.txt");
                //Begin:
                    if (loginform.users.ContainsKey(name) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pass))
                    {
                        MessageBox.Show("User Name already used.");
                    //goto Begin; 
                        writer.Close();
                        return;
                    }
                writer.Write($"User_Name->{name}.Pass->{pass}.\n");
                usernameT.Text = "";
                passwordT.Text = "";
                MessageBox.Show("Accepet");
                writer.Close();
                loginform.AccountsReader();
                loginB_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        
    }
}
