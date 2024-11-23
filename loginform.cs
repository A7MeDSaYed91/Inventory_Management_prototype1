using System.Collections.Generic;

namespace Inventory
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> users = new Dictionary<string, string>();

        public static void AccountsReader()
        {
            users.Clear();
            StreamReader reader;
            reader = File.OpenText("D:\\Final_Project\\Inventory_Management_prototype1\\Files\\Accounts\\Saves.txt");
            while (!reader.EndOfStream)
            {
                string temp = reader.ReadLine();
                string nameL = "", passL = "";
                int i = 11, size = temp.Length;
                for (; i < size; i++)
                {
                    if (temp[i] != '.' && temp[i + 1] != 'P')
                    {
                        nameL += temp[i];
                    }
                    else
                        break;
                }
                i += 7;
                for (; i < size; i++)
                {
                    if (temp[i] != '.' && i != size - 1)
                    {
                        passL += temp[i];
                    }
                    else
                        break;
                }
                users[nameL] = passL;

            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AccountsReader();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginB_Click(object sender, EventArgs e)
        {
            try
            {
                string name, pass;
                name = usernameT.Text.ToString();
                pass = passwordT.Text.ToString();
                if (users[name] == pass)
                {
                    Form2 objForm = new Form2();
                    objForm.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("User Name or Password wrong!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showpassCK_CheckedChanged(object sender, EventArgs e)
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

        private void signupB_Click(object sender, EventArgs e)
        {
            SignUp signform = new SignUp();
            signform.Show();
            this.Visible = false;
        }
    }
}
