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
    public partial class fruit : Form
    {
        DataTable dt = new DataTable();
        Int32 currID = 0;
        Int32 num_right = 0;
        public int _score = 0;

        public int score
        {
            get { return _score; }
            set { _score = value; }
        }

        public fruit()
        {
            InitializeComponent();


            // ----> Datatable for fruit <-----
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("En", typeof(string));


            dt.Rows.Add(0, "apple");
            dt.Rows.Add(1, "banana");
            dt.Rows.Add(2, "cherry");
            dt.Rows.Add(3, "coconut");
            dt.Rows.Add(4, "grape");
            dt.Rows.Add(5, "lemon");
            dt.Rows.Add(6, "mango");
            dt.Rows.Add(7, "orange");
            dt.Rows.Add(8, "papaya");
            dt.Rows.Add(9, "pear");



        }

        private void fruit_Load(object sender, EventArgs e)
        {

        }
    }
}
