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
        DataTable Fruit = new DataTable();
        DataTable Animal = new DataTable();
        DataTable Transport = new DataTable();

        Int32 ID = 0;
        Int32 CorrectAnswer = 0;
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
            Fruit.Columns.Add("ID", typeof(int));
            Fruit.Columns.Add("En", typeof(string));


            Fruit.Rows.Add(0, "apple");
            Fruit.Rows.Add(1, "banana");
            Fruit.Rows.Add(2, "blueberry");
            Fruit.Rows.Add(3, "grape");
            Fruit.Rows.Add(4, "kiwi");
            Fruit.Rows.Add(5, "orange");
            Fruit.Rows.Add(6, "papaya");
            Fruit.Rows.Add(7, "pineapple");
            Fruit.Rows.Add(8, "strawberry");
            Fruit.Rows.Add(9, "watermelon");

            //animal
            Animal.Columns.Add("ID", typeof(int));
            Animal.Columns.Add("En", typeof(string));


            Animal.Rows.Add(0, "cat");
            Animal.Rows.Add(1, "cock");
            Animal.Rows.Add(2, "deer");
            Animal.Rows.Add(3, "dog");
            Animal.Rows.Add(4, "fish");
            Animal.Rows.Add(5, "fox");
            Animal.Rows.Add(6, "giraffe");
            Animal.Rows.Add(7, "lion");
            Animal.Rows.Add(8, "panda");
            Animal.Rows.Add(9, "penguin");

            //transport
            Transport.Columns.Add("ID", typeof(int));
            Transport.Columns.Add("En", typeof(string));


            Transport.Rows.Add(0, "ambulance");
            Transport.Rows.Add(1, "bicycle");
            Transport.Rows.Add(2, "car");
            Transport.Rows.Add(3, "helicopter");
            Transport.Rows.Add(4, "parachutte");
            Transport.Rows.Add(5, "plane");
            Transport.Rows.Add(6, "ship");
            Transport.Rows.Add(7, "train");
            Transport.Rows.Add(8, "truck");
            Transport.Rows.Add(9, "van");


            if (category == "animal")
            {
                dt = Animal;
            }

            else if (category == "fruit")
            {
                dt = Fruit;
            }

            else if (category == "transport")
            {
                dt = Transport;
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

        private void ChangeImage(Int32 ID)
        {
            if (this.category == "fruit")
            {
                switch (ID)
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
                switch (ID)
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
                switch (ID)
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
            if (ID < dt.Rows.Count - 1)
            {
                ID++;
                ChangeImage(ID);
                richTextBox1.Clear();
            }
            else
            {
                string result = "Bạn đã đạt được " + score.ToString() + "điểm!!! Số câu đúng là: " + CorrectAnswer.ToString();
                MessageBox.Show(result);
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ID < dt.Rows.Count )
                {
                    if (richTextBox1.Text.Trim() == Convert.ToString(dt.Rows[ID][1]))
                    {
                        score += 3;
                        CorrectAnswer += 1;
                    }


                    ID++;
                    label1.Text = Convert.ToString(score);
                    label2.Text = Convert.ToString(CorrectAnswer);
                    richTextBox1.Clear();

                    ChangeImage(ID);
                }
                else
                {
                    string result = "Bạn đã đạt được " + score.ToString() + " điểm!!! Số câu đúng là: " + CorrectAnswer.ToString();
                    MessageBox.Show(result);
                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
