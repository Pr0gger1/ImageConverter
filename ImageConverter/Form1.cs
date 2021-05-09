using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageEdit;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        Bitmap Picture;
        private readonly string[] resolutionIcon = { "16x16", "32x32", "64x64", "128x128", "256x256", "512x512" };
        private readonly string[] extensions = { "ICO", "PNG", "JPG" };

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
                    Picture = new Bitmap(Image.FromFile(OpenFile.FileName));
                    ImgBox.Image = Picture;
                }
                catch
                {
                    MessageBox.Show("Неверный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (ImgBox.Image != null)
            {
                
                FileExtension.Items.AddRange(extensions);
            }
        }

        private void SaveTo_Click(object sender, EventArgs e)
        {
            //if (ImgBox.Image != null)
            //{
            //    FolderBrowserDialog ChangeDirectory = new FolderBrowserDialog
            //    {
            //        Description = "Выберите папку для сохранения файла"
            //    };

            //    if (ChangeDirectory.ShowDialog() == DialogResult.OK)
            //    {
            //        string Path = ChangeDirectory.SelectedPath;
            //        MessageBox.Show($"{NameFile}");
            //        ImgBox.Image.Save(Path + "/img.png", ImageFormat.Png);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Вы не выбрали изображение", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            if (ImgBox.Image != null)
            {
                SaveFileDialog SaveFile = new SaveFileDialog
                {
                    Title = "Сохранить картинку как",
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    ShowHelp = true,
                    Filter = $"Image Files(*.{FileExtension.SelectedItem})|*.{(FileExtension.SelectedItem.ToString().ToLower())}"
                };
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
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
                                        Image pic = Resizer.Change_Size_Img(Picture, new Size(res_select, res_select));
                                        pic.Save(SaveFile.FileName, System.Drawing.Imaging.ImageFormat.Icon);
                                    }
                                    
                                    else
                                    {
                                        res_select = Convert.ToInt16(res.Substring(0, 2));

                                        Image pic = Resizer.Change_Size_Img(Picture, new Size(res_select, res_select));
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
