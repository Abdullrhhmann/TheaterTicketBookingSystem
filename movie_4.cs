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
    public partial class movie_4 : Form
    {
        public movie_4()
        {
            InitializeComponent();
        }

        private void movie_4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            movieName.Moviename = "DUNE 2";
            new snacks().Show();
        }
    }
}
