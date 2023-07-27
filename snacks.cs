using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LE_GRAND_REX_BETA
{

    public partial class snacks : Form
    {
      
        
        public snacks()
        {
            InitializeComponent();
            

            MovieName_lbl.Text = movieName.Moviename;



        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            double number = 0;
            try { 
            Double.TryParse(t_numBox1.Text, out double num);
            number=num;

            }catch 
            {
                MessageBox.Show("please enter a vailed number");
            }

            if (t_numBox1.Text == ""|| number<=0 || number>4 )
            {
                MessageBox.Show("please select a number from 1 to 4 ");
            }
            else
            {
            double total=0;

            try {

                if (Double.TryParse(t_numBox1.Text, out double t_num))
                {
                    total = t_num*60;
                }
                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            if (checkBox1.Checked)
            {
                total = total + 45;
            }
            if (checkBox2.Checked)
            {
                total = total + 75;
            }
            if (checkBox3.Checked)
            {
                total = total + 95;
            }
            if (checkBox4.Checked)
            {
                total = total + 110;
            }
            if (checkBox5.Checked)
            {
                total = total + 120;
            }
            if (checkBox6.Checked)
            {
                total = total + 140 ;
            }


            try { 
            Total_label.Text = total.ToString()+"$";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            MessageBox.Show("thank you for booking with us ","success",MessageBoxButtons.OK,MessageBoxIcon.Information);







            }
        }

        private void snacks_Load(object sender, EventArgs e)
        {

        }
    }
}
