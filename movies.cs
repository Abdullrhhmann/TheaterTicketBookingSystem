using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LE_GRAND_REX_BETA
{
    public partial class movies : Form
    {
        public movies()
        {
            InitializeComponent();
            
        }

        private void movies_Load(object sender, EventArgs e)
        {
            welcome_label.Text = "good morning "+userName.name+" book now ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new movie_1().Show();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new movie_6().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new movie_2().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new movie_3().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new movie_4().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new movie_5().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new movie_10().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new movie_8().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new movie_9().Show();
        }
    }
}
