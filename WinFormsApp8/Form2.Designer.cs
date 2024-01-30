namespace WinFormsApp8
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            buttonTTI = new Button();
            buttonSTI = new Button();
            panel3 = new Panel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            panelLeft = new Panel();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            button3 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonTTI);
            panel1.Controls.Add(buttonSTI);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 697);
            panel1.TabIndex = 0;
            // 
            // buttonTTI
            // 
            buttonTTI.FlatAppearance.BorderSize = 0;
            buttonTTI.FlatStyle = FlatStyle.Flat;
            buttonTTI.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTTI.ForeColor = Color.Black;
            buttonTTI.Image = (Image)resources.GetObject("buttonTTI.Image");
            buttonTTI.Location = new Point(0, 170);
            buttonTTI.Name = "buttonTTI";
            buttonTTI.Size = new Size(140, 160);
            buttonTTI.TabIndex = 1;
            buttonTTI.Text = "Текст към снимка";
            buttonTTI.TextAlign = ContentAlignment.BottomCenter;
            buttonTTI.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonTTI.UseVisualStyleBackColor = true;
            buttonTTI.Click += buttonTTI_Click;
            // 
            // buttonSTI
            // 
            buttonSTI.FlatAppearance.BorderSize = 0;
            buttonSTI.FlatStyle = FlatStyle.Flat;
            buttonSTI.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSTI.ForeColor = Color.Black;
            buttonSTI.Image = (Image)resources.GetObject("buttonSTI.Image");
            buttonSTI.Location = new Point(0, 485);
            buttonSTI.Name = "buttonSTI";
            buttonSTI.Size = new Size(140, 160);
            buttonSTI.TabIndex = 2;
            buttonSTI.Text = "Скица към снимка";
            buttonSTI.TextAlign = ContentAlignment.BottomCenter;
            buttonSTI.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonSTI.UseVisualStyleBackColor = true;
            buttonSTI.Click += buttonSTI_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label1);
            panel3.Font = new Font("CaskaydiaCove NF", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 62);
            panel3.TabIndex = 0;
            panel3.MouseDown += Form2_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("CaskaydiaCove NF", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 0;
            label1.Text = "AI ArtVision";
            label1.MouseDown += Form2_MouseDown;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Silver;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.WindowFrame;
            richTextBox1.Location = new Point(156, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(512, 95);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "Описание...";
            richTextBox1.Enter += TBox_Enter;
            richTextBox1.Leave += TBox_Leave;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(156, 0);
            label2.Name = "label2";
            label2.Size = new Size(512, 62);
            label2.TabIndex = 3;
            label2.Text = "Описание:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.MouseDown += Form2_MouseDown;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Gray;
            panelLeft.Location = new Point(143, 485);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(7, 160);
            panelLeft.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(156, 206);
            button1.Name = "button1";
            button1.Size = new Size(512, 34);
            button1.TabIndex = 5;
            button1.Text = "Генерирай";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(156, 243);
            label3.Name = "label3";
            label3.Size = new Size(512, 38);
            label3.TabIndex = 6;
            label3.Text = "Пауза";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(156, 284);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(156, 166);
            button2.Name = "button2";
            button2.Size = new Size(149, 34);
            button2.TabIndex = 8;
            button2.Text = "Избери снимка";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Silver;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = SystemColors.WindowFrame;
            richTextBox2.Location = new Point(311, 166);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(357, 34);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(640, 12);
            button3.Name = "button3";
            button3.Size = new Size(29, 30);
            button3.TabIndex = 10;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightGray;
            ClientSize = new Size(681, 697);
            Controls.Add(button3);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panelLeft);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(62, 120, 138);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form1";
            FormClosed += f2_Closed;
            MouseDown += Form2_MouseDown;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Button buttonTTI;
        private Button buttonSTI;
        private RichTextBox richTextBox1;
        private Label label2;
        private Panel panelLeft;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button2;
        private RichTextBox richTextBox2;
        private Button button3;
    }
}
