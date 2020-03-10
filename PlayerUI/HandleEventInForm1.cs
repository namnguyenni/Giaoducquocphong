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
    class HandleEventInForm1
    {
        public HandleEventInForm1()
        {
//C:\Github\Giaoducquocphong\PlayerUI\ImageAndVideo\Vukhi\Image\AK47\AK_CAUTAO1.JPG
        }
        public static void ShowCautao(PictureBox pic,int code,int stt)
        {
            //string = \ImageAndVideo\Vukhi\Image\AK47\
            string LINK = "";

            switch (code)
            {
                case 1:
                    string linkAK = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    if (CheckCountIn(@"..\..\ImageAndVideo\Vukhi\Image\AK47",stt))
                    {
                        pic.Image = Image.FromFile(linkAK);
                        pic.Refresh();
                        pic.Visible = true;
                        
                    }
                    
                    break;
                case 2:
                    string linkChinhtri = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    pic.Image = Image.FromFile(linkChinhtri);
                    pic.Refresh();
                    pic.Visible = true;
                    break;
                    break;
                case 3 :
                    string linkChienthuat = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    pic.Image = Image.FromFile(linkChienthuat);
                    pic.Refresh();
                    pic.Visible = true;
                    break;
                    break;
                case 4:
                    string linkDieulenh = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    pic.Image = Image.FromFile(linkDieulenh);
                    pic.Refresh();
                    pic.Visible = true;
                    break;
                    break;


                default:
                    break;
            }
           
        }


        public static bool CheckCountIn(string path,int stt)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            int count = dir.GetFiles().Length;
            if (stt<=count && stt>=1)
            {
                return true;
            }



            return false;
        }
    }
}
