namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTTI_Click(object sender, EventArgs e)
        {
            /*
            panelLeft.Height = buttonTTI.Height;
            panelLeft.Top = buttonTTI.Top;
            */
        }

        private void buttonSTI_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSTI.Height;
            panelLeft.Top = buttonSTI.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            richTextBox1.ReadOnly = true;
            buttonSTI.Enabled = false;
            buttonTTI.Enabled = false;

        }
    }
}
