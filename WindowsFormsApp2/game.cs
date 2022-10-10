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

        public string category;

        public game(string category)
        {
            InitializeComponent();

            this.category = category;


            // ----> Datatable for fruit <-----
            dt_Fruit.Columns.Add("ID", typeof(int));
            dt_Fruit.Columns.Add("En", typeof(string));


            dt_Fruit.Rows.Add(0, "apple");
            dt_Fruit.Rows.Add(1, "banana");
            dt_Fruit.Rows.Add(2, "cherry");
            dt_Fruit.Rows.Add(3, "coconut");
            dt_Fruit.Rows.Add(4, "grape");
            dt_Fruit.Rows.Add(5, "lemon");
            dt_Fruit.Rows.Add(6, "mango");
            dt_Fruit.Rows.Add(7, "orange");
            dt_Fruit.Rows.Add(8, "papaya");
            dt_Fruit.Rows.Add(9, "pear");

            //

            if (category == "z")
            {
                dt = dt_Animal;
            }

            else if (category == "fruit")
            {
                dt = dt_Fruit;
            }

            else if (category == "y")
            {
                dt = dt_Vehicle;
            }

        }

        //public string category;
        private void game_Load(object sender, EventArgs e)
        {
            if (this.category == "fruit")
                pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.apple;
            else if (this.category == "animal")
                pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.cat;
            else if (this.category == "transport")
                pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ambulance;
        }

        private void ChangeImage(Int32 currID)
        {
            if (this.category == "fruit")
            {
                switch (currID)
                {
                    case 0:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.apple;
                        break;
                    case 1:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.banana;
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.blueberry;
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.grape;
                        break;
                    case 4:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.kiwi;
                        break;
                    case 5:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.orange;
                        break;
                    case 6:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.papaya;
                        break;
                    case 7:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.pineapple;
                        break;
                    case 8:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.strawberry;
                        break;
                    case 9:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.watermelon;
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
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.cock;
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.deer;
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.dog;
                        break;
                    case 4:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.fish;
                        break;
                    case 5:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.fox;
                        break;
                    case 6:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.giraffe;
                        break;
                    case 7:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.lion;
                        break;
                    case 8:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.panda;
                        break;
                    case 9:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.penguin;
                        break;
                    default:
                        break;
                }
            }

            else if (this.category == "transport")
            {
                switch (currID)
                {
                    case 0:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ambulance;
                        break;
                    case 1:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.bicycle;
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.car;
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.helicopter;
                        break;
                    case 4:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.parachutte;
                        break;
                    case 5:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.plane;
                        break;
                    case 6:
                        pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ship;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currID < dt.Rows.Count - 1)
            {
                currID++;
                ChangeImage(currID);
            }
        }
    }
}
