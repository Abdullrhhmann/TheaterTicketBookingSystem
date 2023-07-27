using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace LE_GRAND_REX_BETA
{
   

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=DB_Users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();




        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
           new RegisterForm().Show();
            //this.Hide();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            SignUpButton.ForeColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            SignUpButton.ForeColor = Color.Gray;
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            UserBox1.Text = "";
            PassBox1.Text = "";
            UserBox1.Focus();
        }

        private void PassCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PassCheckBox1.Checked)
            {
                PassBox1.PasswordChar = '\0';

            }
            else
            {
                PassBox1.PasswordChar = '*';
            }
        }

        private void LoginButton_MouseHover(object sender, EventArgs e)
        {

            LoginButton.ForeColor=Color.Gray;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_Users WHERE Username='" + UserBox1.Text + "'and Password='" + PassBox1.Text + "'";
            cmd=new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {

                userName.name = UserBox1.Text;
                new movies().Show();
            }
            else
            {
                MessageBox.Show("wrong password or email ! , try again", "login faild",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UserBox1.Text = "";
                PassBox1.Text = "";
                UserBox1.Focus();
            }
            con.Close();
        }
       


        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor=Color.LightGoldenrodYellow;
        }

        private void darckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void UserBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pictureBox9_MouseLeave_1(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor=Color.Black;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BackColor = Color.LightGoldenrodYellow;
            
        }
    }
    static class Program
    {
        static void Main()
        {
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }
    }
}
