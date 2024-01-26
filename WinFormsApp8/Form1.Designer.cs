namespace WinFormsApp8
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
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 62);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 0;
            label1.Text = "AI ArtVision";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Silver;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.WindowFrame;
            richTextBox1.Location = new Point(156, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(512, 135);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "Описание тук";
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
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Gray;
            panelLeft.Location = new Point(143, 170);
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
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightGray;
            ClientSize = new Size(681, 697);
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
            Name = "Form1";
            Text = "Form1";
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
    }
}
