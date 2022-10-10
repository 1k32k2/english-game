using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            game chooseTopic = new game("game");
            chooseTopic.Show(this);
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            game chooseTopic = new game("animal");
            chooseTopic.Show(this);
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            game chooseTopic = new game("transport");
            chooseTopic.Show(this);

        }

        private void choose_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
