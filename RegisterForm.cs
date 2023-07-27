using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    

namespace LE_GRAND_REX_BETA
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
         
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=DB_Users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
              
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserBox2.Clear();
            PassBox2.Clear();
            NameBox2.Clear();
            EmailBox2.Clear();
        }

        private void SignUpButton2_Click(object sender, EventArgs e)
        {
            if (UserBox2.Text == "" || PassBox2.Text == "" || NameBox2.Text == "" || EmailBox2.Text == "") {
                MessageBox.Show("you cannot leave this boxes empty !! ", "sign up failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PassBox2.Text == ConPassBox2.Text)
            {
                try
                {
                    if (check_special.Sp_ch(UserBox2.Text))
                    {

                        //MessageBox.Show("don't use special characters ", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        new Error().ShowDialog();
                        UserBox2.Text = "";
                        PassBox2.Text = "";
                        ConPassBox2.Text = "";
                        NameBox2.Text = "";
                        EmailBox2.Text = "";
                        UserBox2.Focus();

                    }else
                    { 
                    con.Open();

                    string register = "INSERT INTO tbl_Users VALUES('" + UserBox2.Text + "' , '" + PassBox2.Text + "' ,'" + NameBox2.Text + "','" + EmailBox2.Text + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    UserBox2.Text = "";
                    PassBox2.Text = "";
                    ConPassBox2.Text = "";
                    NameBox2.Text = "";
                    EmailBox2.Text = "";
                    


                    MessageBox.Show("your account has been created !! ", "Registration success ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch
                {
                    if (check_special.Sp_ch(UserBox2.Text))
                    {

                        MessageBox.Show("don't use special characters ", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserBox2.Text = "";
                        PassBox2.Text = "";
                        ConPassBox2.Text = "";
                        NameBox2.Text = "";
                        EmailBox2.Text = "";
                        UserBox2.Focus();

                    }
                    
                    
                        MessageBox.Show("user already used ", "try another ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            } 
            else {
                MessageBox.Show("passwords doesn't match !!, please reenter your Password","registration failed ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                PassBox2.Text = "";
                ConPassBox2.Text = "";
                PassBox2.Focus();
            }
        }

        private void PassCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(PassCheckBox2.Checked)
            {
                PassBox2.PasswordChar = '\0';
                ConPassBox2.PasswordChar = '\0';

            }
            else
            {
                PassBox2.PasswordChar = '*';
                ConPassBox2.PasswordChar = '*';
            }
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            UserBox2.Text = "";
            PassBox2.Text = "";
            ConPassBox2.Text = "";
            NameBox2.Text = "";
            EmailBox2.Text = "";
            UserBox2.Focus();
        }

        private void LoginButton2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
           // this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
