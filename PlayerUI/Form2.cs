using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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


        }

        private void btn_Luudan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            btn_Pause.Visible = false;
            btn_Continue.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
            btn_Pause.Visible = true ;
            btn_Continue.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isPlaying())
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 15;
        }


        private void button17_Click(object sender, EventArgs e)
        {
            if(isPlaying())
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 15;
        }
        private bool isPlaying()
        {
            return axWindowsMediaPlayer1.playState == WMPPlayState.wmppsReady || axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying;
        }


    }
}
