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
    public partial class movie_7 : Form
    {
        public movie_7()
        {
         
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            movieName.Moviename = "TPOTO";
            new snacks().Show();
        }
    }
}
