using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownTimer
{
    public partial class Form1 : Form
    {

        private DateTime starttime;
        private DateTime endTime;

        public Form1()
        {
            InitializeComponent();

            starttime = new DateTime(2019, 10, 24, 10, 10, 0);
            endTime = new DateTime(2019, 11, 4);

            this.StartPosition = FormStartPosition.Manual;
            tmrCountdown.Enabled = true;
        }

        private void TmrCountdown_Tick(object sender, EventArgs e)
        {
            var difference = endTime - DateTime.Now;
            label1.Text = $"{difference.Days:00}d{difference.Hours:00}:{difference.Minutes:00}:{difference.Seconds:00}";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var wa = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            var newLocation = new Point( wa.Right - this.Width, wa.Bottom - this.Height);
            this.Location = newLocation;
        }
    }
}
