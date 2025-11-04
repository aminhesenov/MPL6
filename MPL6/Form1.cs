namespace MPL6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i -= 10;
            if (i < 0)
            {
                MessageBox.Show("Value cannot be less than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                progressBar1.Value = i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i += 10;
            if (i > 100)
            {
                MessageBox.Show("Value cannot be less than 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                progressBar1.Value = i;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text += e.KeyChar.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = "Button down";
            label3.Text = "label3";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label3.Text = "Button up";
            label2.Text = "label2";
        }
        Random r = new Random();
        Random g = new Random();
        Random b = new Random();

        Random xLocation = new Random();
        Random yLocation = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Size = new Size(50, 50);
            panel.BackColor = Color.FromArgb(r.Next(0, 256), g.Next(0, 256), b.Next(0, 256));
            panel.Location = new Point(xLocation.Next(200, 450), yLocation.Next(20, 380));
            this.Controls.Add(panel);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
