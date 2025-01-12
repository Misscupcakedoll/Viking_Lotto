namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Size = new Size(800, 700);
           
            panel.Size = new Size(550, 500);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Location = new Point(i * 50, j * 50);
                    box.AutoSize = true;
                    box.Text = (j * 8 + i + 1).ToString();
                  
                    panel.Controls.Add(box);
                }
            }
        }
    }
    
}
