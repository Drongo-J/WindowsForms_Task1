using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms__Task1
{
    public partial class Form2 : Form
    {
        Timer timer = new Timer();
        private Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();

            this.Text = "Catch Me";

            timer.Tick += Timer_Tick;
            timer.Start();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            catchBtn.Text = "Catch Me";
            catchBtn.AutoSize = true;
            catchBtn.BackColor = Color.LightBlue;
            catchBtn.Padding = new Padding(6);
            catchBtn.Font = new Font("Segoe Print", 18);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void catchBtn_MouseHover(object sender, EventArgs e)
        {
            int randomX = rnd.Next(0, this.Width - catchBtn.Width);
            int randomY = rnd.Next(0, this.Height - catchBtn.Height - 10);

            catchBtn.Location = new Point(randomX, randomY);
        }
    }
}
