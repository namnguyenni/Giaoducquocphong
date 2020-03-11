using AxWMPLib;
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
        /// <summary>
        /// Hien thi cau tao vao picturebox
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="code"></param>
        /// <param name="stt"></param>
        /// <returns></returns>
        public static bool ShowCautao(PictureBox pic, int code, int stt)
        {
            bool EnableCount = false;
            //string = \ImageAndVideo\Vukhi\Image\AK47\
            string LINK = "";

            switch (code)
            {
                case 1://ak
                    string linkAK = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    if (CheckCountIn(@"..\..\ImageAndVideo\Vukhi\Image\AK47", stt))
                    {
                        pic.Image = Image.FromFile(linkAK);
                        pic.Refresh();
                        pic.Visible = true;
                        EnableCount = true;

                    }

                    break;
                case 2://ckc
                    string linkCKC = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    if (CheckCountIn(@"..\..\ImageAndVideo\Vukhi\Image\AK47", stt))
                    {
                        pic.Image = Image.FromFile(linkCKC);
                        pic.Refresh();
                        pic.Visible = true;
                        EnableCount = true;

                    }
                    break;

                case 3://luu dan
                    string linkLuudan = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    if (CheckCountIn(@"..\..\ImageAndVideo\Vukhi\Image\AK47", stt))
                    {
                        pic.Image = Image.FromFile(linkLuudan);
                        pic.Refresh();
                        pic.Visible = true;
                        EnableCount = true;

                    }
                    break;

                case 4://b41
                    string linkB41 = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    if (CheckCountIn(@"..\..\ImageAndVideo\Vukhi\Image\AK47", stt))
                    {
                        pic.Image = Image.FromFile(linkB41);
                        pic.Refresh();
                        pic.Visible = true;
                        EnableCount = true;

                    }
                    break;
                case 5://k54
                    string linkK54 = @"..\..\ImageAndVideo\Vukhi\Image\" + @"AK47\AK_CAUTAO" + stt + ".JPG";
                    if (CheckCountIn(@"..\..\ImageAndVideo\Vukhi\Image\AK47", stt))
                    {
                        pic.Image = Image.FromFile(linkK54);
                        pic.Refresh();
                        pic.Visible = true;
                        EnableCount = true;

                    }
                    break;


                default:
                    break;
            }
            return EnableCount;

        }


        public static bool CheckCountIn(string path, int stt)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            int count = dir.GetFiles().Length;
            if (stt <= count && stt >= 1)
            {
                stt++;
                return true;
            }



            return false;
        }

        /// <summary>
        /// Hiển thị video mô phỏng của các phần
        /// </summary>
        /// <param name="code"></param>
        public void ShowVideoMophong(int code,AxWindowsMediaPlayer mediaPlayer)
        {
            switch (code)
            {
                case 1 ://video ak
                    string Path = @"..\..\ImageAndVideo\Vukhi\Video\AK47\AK47_MOPHONG1.mp4";
                    mediaPlayer.URL = Path;
                    
                    //mediaPlayer.controls.play();
                    break;
                case 2 :
                    break;
                case 3 :
                    break;


                default:
                    break;
            }

        }

    }
}
