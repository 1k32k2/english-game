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
        DataTable dt_Transport = new DataTable();

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


            //fruit data
            dt_Fruit.Columns.Add("ID", typeof(int));
            dt_Fruit.Columns.Add("En", typeof(string));


            dt_Fruit.Rows.Add(0, "apple");
            dt_Fruit.Rows.Add(1, "banana");
            dt_Fruit.Rows.Add(2, "blueberry");
            dt_Fruit.Rows.Add(3, "grape");
            dt_Fruit.Rows.Add(4, "kiwi");
            dt_Fruit.Rows.Add(5, "orange");
            dt_Fruit.Rows.Add(6, "papaya");
            dt_Fruit.Rows.Add(7, "pineapple");
            dt_Fruit.Rows.Add(8, "strawberry");
            dt_Fruit.Rows.Add(9, "watermelon");

            //animal
            dt_Animal.Columns.Add("ID", typeof(int));
            dt_Animal.Columns.Add("En", typeof(string));


            dt_Animal.Rows.Add(0, "cat");
            dt_Animal.Rows.Add(1, "cock");
            dt_Animal.Rows.Add(2, "deer");
            dt_Animal.Rows.Add(3, "dog");
            dt_Animal.Rows.Add(4, "fish");
            dt_Animal.Rows.Add(5, "fox");
            dt_Animal.Rows.Add(6, "giraffe");
            dt_Animal.Rows.Add(7, "lion");
            dt_Animal.Rows.Add(8, "panda");
            dt_Animal.Rows.Add(9, "penguin");

            //transport
            dt_Transport.Columns.Add("ID", typeof(int));
            dt_Transport.Columns.Add("En", typeof(string));


            dt_Transport.Rows.Add(0, "ambulance");
            dt_Transport.Rows.Add(1, "bicycle");
            dt_Transport.Rows.Add(2, "car");
            dt_Transport.Rows.Add(3, "helicopter");
            dt_Transport.Rows.Add(4, "parachutte");
            dt_Transport.Rows.Add(5, "plane");
            dt_Transport.Rows.Add(6, "ship");
            dt_Transport.Rows.Add(7, "train");
            dt_Transport.Rows.Add(8, "truck");
            dt_Transport.Rows.Add(9, "van");


            if (category == "animal")
            {
                dt = dt_Animal;
            }

            else if (category == "fruit")
            {
                dt = dt_Fruit;
            }

            else if (category == "transport")
            {
                dt = dt_Transport;
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
                //
                label3.Text = Convert.ToString(dt.Rows[currID][1]);
                label4.Text = Convert.ToString(currID);
                //
            }
            else
            {
                string result = "point: " + label1.Text;
                MessageBox.Show(result);
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            //label3.Text = Convert.ToString(dt.Rows[currID][1]);
            //label4.Text = Convert.ToString(currID);
            //
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (currID < dt.Rows.Count - 1)
                {
                    if (richTextBox1.Text.Trim() == Convert.ToString(dt.Rows[currID][1]))
                    {
                        score += 3;
                        num_right += 1;
                    }


                    currID++;
                    label1.Text = Convert.ToString(score);
                    label2.Text = Convert.ToString(num_right);
                    richTextBox1.Clear();

                    ChangeImage(currID);
                }
                else
                {
                    string result = "point: " + label1.Text;
                    MessageBox.Show(result);
                }

            }
        }
    }
}
