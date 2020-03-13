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
        private int STT = 1;
        private bool ImageShowed = false;
        private Button CurrentButton = null;
        private Panel currentSubMenu = null;
        private Form form2 = null;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void HideSubPanel()
        {
            panelSubMenuVukhi.Visible = false;
            panelSubMenuDieulenh.Visible = false;
            panelSubMenuChienthuat.Visible = false;
            panelSubMenuChinhtri.Visible = false;
        }
        private void ShowSubPanel(Panel panel)
        {
            if (currentSubMenu == panel)
            {
                STT = 1;
                panel.Visible = true;
            }
            else
            {
                HideSubPanel();
                STT = 1;
                panel.Visible = true ;
                currentSubMenu = panel;
            }
            
                
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelChienthuat.Visible = false;
            PanelChinhtri.Visible = false;


        }



        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false ;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void btn_AK47_Click(object sender, EventArgs e)
        {
             
                CurrentButton = btn_AK47;
                ShowSubPanel(panelSubMenuVukhi);
                
            
            
        }

        private void btn_CKC_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_CKC;
            ShowSubPanel(panelSubMenuVukhi);
        }

        private void btn_B41_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_B41;
            ShowSubPanel(panelSubMenuVukhi);
        }

        private void btn_Luudan_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_Luudan;
            ShowSubPanel(panelSubMenuVukhi);
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void btn_Bai1_Dieulenh_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_Bai1_Dieulenh;
            ShowSubPanel(panelSubMenuDieulenh);
        }

        private void btn_Bai2_Dieulenh_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_Bai2_Dieulenh;
            ShowSubPanel(panelSubMenuDieulenh);
        }

        private void btn_Bai3_Dieulenh_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_Bai3_Dieulenh;
            ShowSubPanel(panelSubMenuDieulenh);
        }

        private void btn_Bai4_Dieulenh_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_Bai4_Dieulenh;
            ShowSubPanel(panelSubMenuDieulenh);
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChienthuat);
        }
        #region ToolsSubMenu
        private void btn_Bai1_Chienthuat_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_Bai1_Chienthuat;
            ShowSubPanel(panelSubMenuChienthuat);
        }

        private void btn_Bai2_Chienthuat_Click(object sender, EventArgs e)
        {
    
            CurrentButton = btn_Bai2_Chienthuat;
            ShowSubPanel(panelSubMenuChienthuat);
        }

        private void btn_Bai3_Chienthuat_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_Bai3_Chienthuat;
            ShowSubPanel(panelSubMenuChienthuat);
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
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
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

        private void btn_K54_Click(object sender, EventArgs e)
        {

            CurrentButton = btn_K54;
            ShowSubPanel(panelSubMenuVukhi);
        }

        private void btnEqualizer_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelChinhtri);
        }

        private void Placeholder(string text,TextBox tbx)
        {
            tbx.Text = text;
            
        }

        private void Search_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_trangchinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();

        }

        private void btn_Cautao_Click_1(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.Close();
            }
            pictureBox1.BringToFront();
            string textKey = CurrentButton.Text.ToString();
            switch (textKey)
            {
                case "AK 47":
                    HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 1, STT);
                    ImageShowed = true;
                    break;
                case "CKC":
                    HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 2, STT);
                    ImageShowed = true;
                    break;
                case "Lựu đạn":
                    HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 3, STT);
                    ImageShowed = true;
                    break;
                case "B41":
                    HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 4, STT);
                    ImageShowed = true;
                    break;
                case "K54":
                    HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 5, STT);
                    ImageShowed = true;
                    break;

                default:
                    break;
            }
            
            
            
            
        }

        private void btn_Mophong_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            openChildForm(form2);
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            if (ImageShowed)
            {
                NextSlideCautao(-1);
            }
            
            
        }

        public void NextSlideCautao(int mode)
        {
            string textKey = CurrentButton.Text.ToString();
            switch (textKey)
            {
                case "AK 47":
                    if (mode == 1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 1, STT + 1))
                    {                       
                        ImageShowed = true;
                        STT++;
                    }
                    else if (mode == -1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 1, STT - 1))
                    {
                        
                        ImageShowed = true;
                        STT--;
                    }
                    break;
                case "CKC":
                    if (mode == 1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 2, STT + 1))
                    {
                        ImageShowed = true;
                        STT++;
                    }
                    else if (mode == -1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 2, STT - 1))
                    {

                        ImageShowed = true;
                        STT--;
                    }
                    break;
                case "Lựu đạn":
                    if (mode == 1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 3, STT + 1))
                    {
                        ImageShowed = true;
                        STT++;
                    }
                    else if (mode == -1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 3, STT - 1))
                    {

                        ImageShowed = true;
                        STT--;
                    }
                    break;
                case "B41":
                    if (mode == 1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 4, STT + 1))
                    {
                        ImageShowed = true;
                        STT++;
                    }
                    else if (mode == -1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 4, STT - 1))
                    {

                        ImageShowed = true;
                        STT--;
                    }
                    break;
                case "K54":
                    if (mode == 1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 5, STT + 1))
                    {
                        ImageShowed = true;
                        STT++;
                    }
                    else if (mode == -1 && HandleEventInForm1.ShowLithuyetVukhi(pictureBox1, 5, STT - 1))
                    {

                        ImageShowed = true;
                        STT--;
                    }
                    break;

                default:
                    break;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (ImageShowed)
            {
                NextSlideCautao(1);
            }
            
        }

        private void btn_LythuyetDieulenh_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bai1_Chinhtri_Click(object sender, EventArgs e)
        {
            
            CurrentButton = btn_Bai1_Chinhtri;
            ShowSubPanel(panelSubMenuChinhtri);
        }

        private void btn_Bai2_Chinhtri_Click(object sender, EventArgs e)
        {
           
            CurrentButton = btn_Bai2_Chinhtri;
            ShowSubPanel(panelSubMenuChinhtri);
        }

        private void btn_Bai3_Chinhtri_Click(object sender, EventArgs e)
        {
       
            CurrentButton = btn_Bai3_Chinhtri;
            ShowSubPanel(panelSubMenuChinhtri);
        }

       


    }
}
