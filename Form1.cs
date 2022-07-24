using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Task1
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Label timerLbl = new Label();
        Label cityLbl = new Label();
        Button switchBtn = new Button();
        bool showBaku = true;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Time Zone";

                
            timerLbl.ForeColor = Color.White;
            timerLbl.Font = new Font("Palatino Linotype", 35, FontStyle.Bold);
            timerLbl.BackColor = Color.Transparent;
            timerLbl.AutoSize = true;

            cityLbl.ForeColor = Color.White;
            cityLbl.Font = new Font("Palatino Linotype", 40, FontStyle.Bold);
            cityLbl.Location = new Point(730, 100);
            cityLbl.BackColor = Color.Transparent;
            cityLbl.AutoSize = true;

            switchBtn.Text = "Switch";
            switchBtn.FlatStyle = FlatStyle.Flat;
            switchBtn.BackColor = Color.DarkBlue;
            switchBtn.ForeColor = Color.Transparent;
            switchBtn.Font = new Font("Palatino Linotype", 35, FontStyle.Bold);
            switchBtn.Padding = new Padding(6);
            switchBtn.Location = new Point(550, 630);
            switchBtn.AutoSize = true;
            switchBtn.Click += SwitchBtn_Click;

            timer.Tick += Timer_Tick;
            timer.Start();

            this.Height = 760;
            this.Width = 1293;

            this.BackgroundImage = WindowsForms__Task1.Properties.Resources.LondonView;
            this.Controls.Add(timerLbl);
            this.Controls.Add(switchBtn);
            this.Controls.Add(cityLbl);
        }

        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            if (showBaku)
            {
                cityLbl.Text = "Baku : ";
                this.BackgroundImage = WindowsForms__Task1.Properties.Resources.BakuView23;
                showBaku = false;
            }
            else
            {
                cityLbl.Text = "";
                this.BackgroundImage = WindowsForms__Task1.Properties.Resources.LondonView;
                showBaku = true;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!showBaku)
            {
                timerLbl.Location = new Point(900, 109);
                this.timerLbl.Text = DateTime.Now.ToLongTimeString();
            }
            else
            {
                timerLbl.Location = new Point(470, 109);
                this.timerLbl.Text = DateTime.Now.AddHours(-4).ToLongTimeString();
            }
        }
    }
}
