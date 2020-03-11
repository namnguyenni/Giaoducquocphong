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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private int STT = 1;
        private bool ImageShowed = false;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelSubmenuVukhi.Visible = false;
            panelSubmenuDieulenh.Visible = false;
            panelToolsSubMenu.Visible = false;
            PanelSubmenuChinhtri.Visible = false;
            panelSubmenuAK47.Visible = false;
            panelSubmenuCKC.Visible = false;
            panelSubmenuK54.Visible = false;
            panelSubmenuLuuDan.Visible = false;
            panelSubmenuB41.Visible = false;
            panelSubmenuM79.Visible = false;
        }   

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnVukhi_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuVukhi);
        
        }

        #region MediaSubMenu
        private void btn_AK47_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuAK47);
        }
    

        private void btn_CKC_Click(object sender, EventArgs e)
        {

            showSubMenu(panelSubmenuCKC);

        }

        private void btn_B41_Click(object sender, EventArgs e)
        {

            showSubMenu(panelSubmenuB41);
        }

        private void btn_Luudan_Click(object sender, EventArgs e)
        {

            showSubMenu(panelSubmenuLuuDan);
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuDieulenh);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
           
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuK54);
        }

        private void btn_Chinhtri_click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubmenuChinhtri);
        }

        private void btn_trangchinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();

        }

        private void btn_AK47_Cautao_Click_1(object sender, EventArgs e)
        {
            HandleEventInForm1.ShowCautao(pictureBox1, 1, STT);
            ImageShowed = true;
           
            
        }

        private void btn_Mophong_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            if (ImageShowed)
            {
                if (HandleEventInForm1.ShowCautao(pictureBox1, 1, STT - 1))
                {
                    STT--;
                }
            }
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (ImageShowed)
            {
                if (HandleEventInForm1.ShowCautao(pictureBox1, 1, STT + 1))
                {
                    STT++;
                }
            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void btn_Chinhtri_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelSubmenuChinhtri);
        }
    }
}
