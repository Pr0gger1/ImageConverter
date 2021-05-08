using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageEdit;

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

            CompRatioBar.Scroll += CompRatioBar_Scroll;           
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
            //if (ImgBox.Image != null)
            //{
            //    FolderBrowserDialog ChangeDirectory = new FolderBrowserDialog();
            //    if (ChangeDirectory.ShowDialog() == DialogResult.OK)
            //    {
            //        string Path = ChangeDirectory.SelectedPath;
            //        MessageBox.Show($"{Path}");
            //    }
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
                            foreach (string res in resolutionIcon)
                            {
                                if (res == ResolutionBox.SelectedItem)
                                {
                                    if (res.Substring(2, 1) != "x")
                                    {
                                        res_select = Convert.ToInt16(res.Substring(0, 3));
                                        Image pic = Resizer.Change_Size_Img(picture, new Size(res_select, res_select));
                                        //Image pic = ResizeImage(picture, new Size(res_select, res_select));
                                        pic.Save(SaveFile.FileName, System.Drawing.Imaging.ImageFormat.Icon);
                                    }
                                    else
                                    {
                                        res_select = Convert.ToInt16(res.Substring(0, 2));

                                        Image pic = Resizer.Change_Size_Img(picture, new Size(res_select, res_select));
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

        private void CompRatioBar_Scroll(object sender, EventArgs e)
        {
            SliderValue.Text = $"Степень сжатия: {CompRatioBar.Value}%";
        }
    }
}
