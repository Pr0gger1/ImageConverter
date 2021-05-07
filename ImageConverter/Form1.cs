using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        Bitmap picture = null;
        private readonly string[] resolutionIcon = { "16x16", "32x32", "64x64", "128x128", "256x256", "512x512", "1024x1024" };

        public Form1()
        {
            InitializeComponent();
            ResolutionBox.Items.AddRange(resolutionIcon);

            trackBar1.Scroll += trackBar1_Scroll;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog
            {
                Filter = "Image Files(*.PNG;*.JPG;*.BMP;*.WEBP)|*.PNG;*.JPG;*.BMP;*.WEBP|All files(*.*)|*.*"
            };
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture = new Bitmap(Image.FromFile(OpenFile.FileName));
                    ImgBox.Image = picture;
                }
                catch
                {
                    MessageBox.Show("Неверный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (ImgBox.Image != null)
            {
                string[] extensions = { "ICO", "PNG", "JPG" };
                FileExtension.Items.AddRange(extensions);
            }
        }

        private void SaveTo_Click(object sender, EventArgs e)
        {
            if (ImgBox.Image != null)
            {
                SaveFileDialog SaveFile = new SaveFileDialog
                {
                    Title = "Сохранить картинку как",
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    ShowHelp = true,
                    Filter = "Image Files(*.PNG)|*.png|Image Files(*.JPG)|*.jpg|Image Files(*.ICO)|*.ico|All Files(*.*)|*.*"
                };
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //System.Drawing.Image img = ImgBox.Image;
                        if (FileExtension.SelectedItem == "PNG")
                        {                          
                            ImgBox.Image.Save(SaveFile.FileName, System.Drawing.Imaging.ImageFormat.Png);                           
                        }
                        else if (FileExtension.SelectedItem == "JPG")
                        {
                            ImgBox.Image.Save(SaveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);                           
                        }
                        else if (FileExtension.SelectedItem == "ICO")
                        {
                            int res_select;
                            foreach(string res in resolutionIcon)
                            {
                                if (res == ResolutionBox.SelectedItem)
                                {
                                    if (res.Substring(2,1) != "x")
                                    {
                                        res_select = Convert.ToInt16(res.Substring(0, 3));

                                        Image pic = ResizeImage(picture, new Size(res_select, res_select));
                                        pic.Save(SaveFile.FileName, System.Drawing.Imaging.ImageFormat.Icon);
                                    }
                                    else
                                    {
                                        res_select = Convert.ToInt16(res.Substring(0, 2));

                                        Image pic = ResizeImage(picture, new Size(res_select, res_select));
                                        pic.Save(SaveFile.FileName, System.Drawing.Imaging.ImageFormat.Icon);
                                    }
                                }
                            }
                        }
                        MessageBox.Show("Успешно сконвертировано!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
        }

        private void FileExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileExtension.SelectedItem == "ICO")
            {
                ResolutionPanel.Visible = true;
            }
            else
            {
                ResolutionPanel.Visible = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SliderValue.Text = $"Степень сжатия: {trackBar1.Value}%";
        }

        private static Image ResizeImage(Image imgToResize, Size size)
        {
            //Get width and height original image
            int origWidth = imgToResize.Width;
            int origHeight = imgToResize.Height;

            //Calculate new resolution
            float nPercent = 0;
            float nPercentW = size.Width / (float)origWidth;
            float nPercentH = size.Height / (float)origHeight;

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
            }
            else
            {
                nPercent = nPercentW;
            }

            int outWidth = (int)(origWidth * nPercent);
            int outHeight = (int)(origHeight * nPercent);
            Bitmap bmp = new Bitmap(outWidth, outHeight);
            Graphics graph = Graphics.FromImage((Image)bmp);

            graph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graph.DrawImage(imgToResize, 0, 0, outWidth, outHeight);
            graph.Dispose();

            return (Image)bmp;
        }
    }

}
