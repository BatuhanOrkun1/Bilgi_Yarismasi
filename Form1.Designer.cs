namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblSoruno = new Label();
            LblDogru = new Label();
            LblYanlis = new Label();
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            BtnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 1;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 2;
            label3.Text = "Yanlış:";
            // 
            // LblSoruno
            // 
            LblSoruno.AutoSize = true;
            LblSoruno.Location = new Point(611, 38);
            LblSoruno.Margin = new Padding(4, 0, 4, 0);
            LblSoruno.Name = "LblSoruno";
            LblSoruno.Size = new Size(23, 28);
            LblSoruno.TabIndex = 3;
            LblSoruno.Text = "0";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new Point(611, 90);
            LblDogru.Margin = new Padding(4, 0, 4, 0);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(23, 28);
            LblDogru.TabIndex = 4;
            LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new Point(611, 143);
            LblYanlis.Margin = new Padding(4, 0, 4, 0);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(23, 28);
            LblYanlis.TabIndex = 5;
            LblYanlis.Text = "0";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(488, 197);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(1, 203);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(250, 47);
            BtnA.TabIndex = 7;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(257, 203);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(232, 47);
            BtnB.TabIndex = 8;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(1, 256);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(250, 47);
            BtnC.TabIndex = 9;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(257, 256);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(232, 47);
            BtnD.TabIndex = 10;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(514, 174);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(143, 60);
            BtnSonraki.TabIndex = 11;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(582, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 318);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 360);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(699, 317);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSonraki);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Controls.Add(LblYanlis);
            Controls.Add(LblDogru);
            Controls.Add(LblSoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblSoruno;
        private Label LblDogru;
        private Label LblYanlis;
        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Button BtnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
