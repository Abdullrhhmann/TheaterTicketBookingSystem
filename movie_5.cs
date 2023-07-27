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
    public partial class movie_5 : Form
    {
        public movie_5()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            movieName.Moviename = "barbie";
            new snacks().Show();
        }
    }
}
