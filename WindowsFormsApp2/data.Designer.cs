namespace WindowsFormsApp2
{
    partial class data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topic,
            this.english,
            this.vie});
            this.dataGridView1.Location = new System.Drawing.Point(28, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // topic
            // 
            this.topic.HeaderText = "topic";
            this.topic.MinimumWidth = 6;
            this.topic.Name = "topic";
            this.topic.Width = 125;
            // 
            // english
            // 
            this.english.HeaderText = "eng";
            this.english.MinimumWidth = 6;
            this.english.Name = "english";
            this.english.Width = 125;
            // 
            // vie
            // 
            this.vie.HeaderText = "vie";
            this.vie.MinimumWidth = 6;
            this.vie.Name = "vie";
            this.vie.Width = 125;
            // 
            // data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.HD_Alphabet_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 477);
            this.Controls.Add(this.dataGridView1);
            this.Name = "data";
            this.Text = "data";
            this.Load += new System.EventHandler(this.data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn english;
        private System.Windows.Forms.DataGridViewTextBoxColumn vie;
    }
}