using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ImageEdit;
using ImageMagick;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        Bitmap Picture;
        string ImgPath;

        private readonly string[] resolutionIcon = { "16x16", "32x32", "64x64", "128x128", "256x256" };
        private readonly string[] extensions = { "ICO", "PNG", "JPG", "BMP" };

        public Form1()
        {
            
            InitializeComponent();
            ResolutionBox.Items.AddRange(resolutionIcon);

            CompRatioBar.Scroll += CompRatioBar_Scroll;

            if (CompRatioBar.Value != 0)
            {
                int Compress_ratio = CompRatioBar.Value;
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog
            {
                Filter = "Image Files(*.PNG;*.JPG;*.BMP;*.ICO)|*.PNG;*.JPG;*.BMP;*.ICO|All files(*.*)|*.*"
            };
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Picture = new Bitmap(Image.FromFile(OpenFile.FileName));
                    ImgPath = OpenFile.FileName;
                    ImgBox.Image = Picture;
                }
                catch
                {
                    MessageBox.Show("Неверный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (ImgBox.Image != null && FileExtension.Items.Count == 0)
            {           
                FileExtension.Items.AddRange(extensions);
            }
        }

        private void SaveTo_Click(object sender, EventArgs e)
        {
            if (ImgBox.Image != null)
            {
                SaveFileDialog SaveFile = new SaveFileDialog()
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
                        var Extension_value = FileExtension.SelectedItem;
                        switch (Extension_value)
                        {
                            case "PNG":
                                ImgBox.Image.Save(SaveFile.FileName, ImageFormat.Png);
                                break;

                            case "JPG":
                                ImgBox.Image.Save(SaveFile.FileName, ImageFormat.Jpeg);
                                break;

                            case "BMP":
                                ImgBox.Image.Save(SaveFile.FileName, ImageFormat.Bmp);
                                break;

                            case "ICO":
                                int res_selectXY;

                                foreach (var res in resolutionIcon) //Brute force "16x16", "32x32", "64x64", "128x128", "256x256"
                                {
                                    if (res == ResolutionBox.SelectedItem.ToString() && ResolutionBox.SelectedItem != null)
                                    {
                                        if (res.Substring(2, 1) != "x") //if third element of array of resolution != 'x' (128x128 == True)
                                        {
                                            res_selectXY = Convert.ToInt16(res.Substring(0, 3)); //Parsing third-digit resolution (input = "128x128" => output = 128)

                                            using (MagickImage Ico = Image_ConvertTO.Ico(ImgPath, res_selectXY))
                                            {
                                                Ico.Write(SaveFile.FileName);
                                            }
                                        }
                                        else
                                        {
                                            res_selectXY = Convert.ToInt16(res.Substring(0, 2)); //Parsing second-digit resolution (input = "64x64" => output = 64)

                                            using (MagickImage Ico = Image_ConvertTO.Ico(ImgPath, res_selectXY))
                                            {
                                                Ico.Write(SaveFile.FileName);
                                            }
                                        }
                                    }
                                }
                                break;
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
