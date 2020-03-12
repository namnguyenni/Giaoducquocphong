using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //E:\Unity\Giaoducquocphong\PlayerUI\ImageAndVideo\Vukhi\Video\AK47\AK47_MOPHONG1.mp4
            InitializeComponent();

            if (new HandleEventInForm1().ShowVideoMophong(1) != "")
            {
                string path = new HandleEventInForm1().ShowVideoMophong(1);
                axWindowsMediaPlayer1.URL = path;
                //axWindowsMediaPlayer1.URL = @"E:\Unity\Giaoducquocphong\PlayerUI\ImageAndVideo\Vukhi\Video\AK47\AK47_MOPHONG1.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
            //new HandleEventInForm1().ShowVideoMophong(1, axWindowsMediaPlayer1);
            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }
    }
}
