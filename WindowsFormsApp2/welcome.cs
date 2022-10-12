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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            choose chooseTopic = new choose();
            chooseTopic.Show(this);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            data data = new data();
            data.Show(this);
        }
    }
}
