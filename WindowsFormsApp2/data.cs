using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }

        private string[] eng = { "apple", "banana", "blueberry", "grape", "kiwi", "orange", "papaya", "pineapple", "strawberry", "watermelon", "cat", "cock", "deer", "dog", "fish", "fox", "girrafe", "lion", "panda", "penguin", "ambulance", "bicycle", "car", "helicopter", "parachutte", "plane", "ship", "train", "truck", "van" };
        public string[] Vie = { "táo", "chuối", "dâu xanh", "nho", "việt quất", "cam", "đủ đủ", "thơm", "dâu", "dưa hấu", "mèo", "gà trống", "nai", "chó", "cá", "cáo", "hươu cao cổ", "hổ", "gấu trúc", "chim cánh cụt", "xe cấp cứu", "xe đạp", "xe hơi", "trực thăng", "dù lượn", "máy bay", "thuyền", "tàu lửa", "xe tải", "xe nhỏ" };

        private void data_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("FRUIT", eng[i], Vie[i]);
            }
            
            for(int i=0; i < 10; i++)
            {
                dataGridView1.Rows.Add("ANIMAL",eng[i+10], Vie[i+10]);
            }

            for(int i=0; i < 10; i++)
            {
                dataGridView1.Rows.Add("TRANSPORT", eng[i + 20], Vie[i + 20]);
            }
        }
    }
}
