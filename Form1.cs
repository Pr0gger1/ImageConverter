using System;
using System.Drawing;
using System.Drawing.Imaging;
using ImageMagick;
using System.Windows.Forms;
using ImageEditor;
using System.IO;

namespace Image_Converter
{
    public partial class MainWindow : Form
    {
        ToolTip prompt = new ToolTip();
        Bitmap Picture;
        string ImgPath;

        private readonly string[] ResolutionIcon = { "16", "32", "64", "128", "256" };
        private readonly string[] ImageExtensions = { "ICO", "PNG", "JPG", "BMP" };
        
        public MainWindow()
        {
            InitializeComponent();
            CompRatio_bar.Scroll += CompRatio_bar_Scroll;
        }

        private void OpenFile_btn_Click(object sender, EventArgs e)
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
                FileExtension.Items.AddRange(ImageExtensions);
            }

        }

        private void SaveFile_btn_Click(object sender, EventArgs e)
        {
            if (ImgBox.Image != null)
            {
                SaveFileDialog SaveFile = new SaveFileDialog()
                {
                    Title = "Сохранить картинку как",
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    ShowHelp = true
                };

                if (FileExtension.SelectedItem == null)
                {
                    SaveFile.Filter = $"Image Files(*{Path.GetExtension(ImgPath)})|*{(Path.GetExtension(ImgPath))}";
                }
                else
                {
                    SaveFile.Filter = $"Image Files(*.{FileExtension.SelectedItem})|*.{(FileExtension.SelectedItem.ToString().ToLower())}";
                }
                

                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var Extension_value = FileExtension.SelectedItem;
                        switch (Extension_value)
                        {
                            case "PNG":
                                
                                Picture.Save(SaveFile.FileName, ImageFormat.Png);
                                break;

                            case "JPG":
                                Picture.Save(SaveFile.FileName, ImageFormat.Jpeg);
                                break;

                            case "BMP":
                                Picture.Save(SaveFile.FileName, ImageFormat.Bmp);
                                break;

                            case "ICO":
                                try
                                {
                                    foreach (string res in ResolutionIcon)
                                    {

                                        if (res == ResolutionX.SelectedItem.ToString())
                                        {
                                            using (MagickImage Ico =ImgEditor.ConvertToIco(ImgPath, Convert.ToInt16(res)))
                                            {
                                                Ico.Write(SaveFile.FileName);
                                            }
                                        }
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Неверное разрешение иконки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                                
                                        //if (res.Substring(2, 1) != "x") //if third element of array of resolution != 'x' (128x128 == True)
                                        //{
                                        //    res_selectXY = Convert.ToInt16(res.Substring(0, 3)); //Parsing third-digit resolution (input = "128x128" => output = 128)

                                        //    using (MagickImage Ico = ImageConvertTo.Ico(ImgPath, res_selectXY))
                                        //    {
                                        //        Ico.Write(SaveFile.FileName);
                                        //    }
                                        //}
                                        //else
                                        //{
                                        //    res_selectXY = Convert.ToInt16(res.Substring(0, 2)); //Parsing second-digit resolution (input = "64x64" => output = 64)

                                        //    using (MagickImage Ico = ImageConvertTo.Ico(ImgPath, res_selectXY))
                                        //    {
                                        //        Ico.Write(SaveFile.FileName);
                                        //    }
                                        //}

                            case null:
                                //ImgEditor NewImage = new ImgEditor();
                                //MagickImage img = ImgEditor.Compress_img(CompRatio_bar.Value, ImgPath);
                                //img.Write(SaveFile.FileName);
                                //var ChRes = NewImage.ChangeResolution(ImgPath, int.Parse(ResolutionX.Text), int.Parse(ResolutionY.Text));
                                //var Compress_img = NewImage.Compress_img(CompRatio_bar.Value ,ImgPath);
                                //MagickImage img = NewImage();
                                //MagickImage img = ImgEditor.ChangeResolution(ImgPath, int.Parse(ResolutionX.Text), int.Parse(ResolutionY.Text));
                                //img.Write(SaveFile.FileName);
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

        private void OpenFile_btn_MouseHover(object sender, EventArgs e)
        {
            prompt.SetToolTip(OpenFile_btn, "Открыть файл");
        }

        private void SaveFile_btn_MouseHover(object sender, EventArgs e)
        {
            prompt.SetToolTip(SaveFile_btn, "Сохранить в...");
        }

        private void ChangeResolution_btn_MouseHover(object sender, EventArgs e)
        {
            prompt.SetToolTip(ChangeResolution_btn, "Изменить разрешение изображения");
        }

        private void CompressImg_btn_MouseHover(object sender, EventArgs e)
        {
            prompt.SetToolTip(CompressImg_btn, "Сжать изображение");
        }

        private void FileExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileExtension.SelectedItem.ToString() == "ICO")
            {
                ResolutionX.Items.AddRange(ResolutionIcon);
                ResolutionY.Items.AddRange(ResolutionIcon);
            }
            else
            {
                ResolutionX.Items.Clear();
                ResolutionY.Items.Clear();
            }
        }

        private void CompRatio_bar_Scroll(object sender, EventArgs e)
        {
            SliderValue.Text = $"Степень сжатия: {CompRatio_bar.Value}%";
        }
    }
}
