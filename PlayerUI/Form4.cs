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
    public partial class Form4 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form4()
        {
            InitializeComponent();
            player.SoundLocation = "music.wav";
            player.Play();
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bai4_Dieulenh_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
