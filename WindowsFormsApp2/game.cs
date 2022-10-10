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
    public partial class game : Form
    {
        DataTable dt = new DataTable();
        DataTable dt_Fruit = new DataTable();
        DataTable dt_Animal = new DataTable();
        DataTable dt_Vehicle = new DataTable();

        Int32 currID = 0;
        Int32 num_right = 0;
        public int _score = 0;

        public int score
        {
            get { return _score; }
            set { _score = value; }
        }

        public game(string category)
        {
            InitializeComponent();

            this.category = category;

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

            //

            if (category == "animal")
            {
                dt = dt_Animal;
            }
            else if (category == "game")
            {
                dt = dt_Fruit;
            }

            else if (category == "vehicle")
            {
                dt = dt_Vehicle;
            }

        }
        public string category;
        private void fruit_Load(object sender, EventArgs e)
        {

        }
        private void ChangeImage(Int32 currID)
        {
            if (this.category == "game")
            {
                switch (currID)
                {
                    case 0:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.tao;
                        break;
                    case 1:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.chuoi;
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.anhdao;
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.dua;
                        break;
                    case 4:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.nho;
                        break;
                    case 5:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.chanh;
                        break;
                    case 6:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.xoai;
                        break;
                    case 7:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.cam;
                        break;
                    case 8:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.dudu;
                        break;
                    case 9:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.quale;
                        break;
                    default:
                        break;
                }
            }
            else if (this.category == "animal")
            {
                switch (currID)
                {
                    case 0:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.cat;
                        break;
                    case 1:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.chicken;
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.cow;
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.dog;
                        break;
                    case 4:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.duck;
                        break;
                    case 5:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.frog;
                        break;
                    case 6:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.horse;
                        break;
                    case 7:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.pig;
                        break;
                    case 8:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.rabbit;
                        break;
                    case 9:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.sheep;
                        break;
                    default:
                        break;
                }
            }

            else if (this.category == "vehicle")
            {
                switch (currID)
                {
                    case 0:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.bicycle;
                        break;
                    case 1:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.bus;
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.car;
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.motorcycle;
                        break;
                    case 4:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.scooter;
                        break;
                    case 5:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.subway;
                        break;
                    case 6:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.taxi;
                        break;
                    case 7:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.train;
                        break;
                    case 8:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.truck;
                        break;
                    case 9:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.van;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
