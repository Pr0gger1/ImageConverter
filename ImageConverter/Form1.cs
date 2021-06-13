using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using Converter;
using Compressing;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        string image_directory;
        Bitmap Picture;

        public Form1()
        {

            InitializeComponent();

            Compression_ratio_bar.Scroll += Compression_ratio_bar_Scroll;
        }

        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            if (Functional_Tab.SelectedTab == Convert_Img_Page)
            {
                if (SelectMultipleFiles_radbtn.Checked)
                {
                    using (var OpenFolder = new FolderBrowserDialog())
                    {
                        if (OpenFolder.ShowDialog() == DialogResult.OK)
                        {
                            SaveImg_btn.Enabled = true;
                            string images_directory = OpenFolder.SelectedPath;
                            txtPathFile.Text = OpenFolder.SelectedPath;

                            try
                            {
                                if (Directory.Exists(images_directory))
                                {
                                    foreach (string file in Directory.GetFiles(images_directory))
                                    {
                                        var Extension_selected = ImgExtension.SelectedItem;
                                        switch (Extension_selected)
                                        {
                                            case "PNG":
                                                ImgFormat.ToPng(file, images_directory);
                                                break;

                                            case "JPG":
                                                ImgFormat.ToJpg(file, images_directory);
                                                break;

                                            case "ICO":
                                                //ImgFormat.ToIco(file, images_directory);
                                                break;

                                            case "BMP":
                                                ImgFormat.ToBmp(file, images_directory);
                                                break;

                                            case "TIFF":
                                                ImgFormat.ToTiff(file, images_directory);
                                                break;
                                        }

                                    }
                                    //MessageBox.Show("Все файлы успешно сконвертированы", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Неверный формат файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (SelectOneFile_radbtn.Checked)
                {
                    using (var OpenFolder = new OpenFileDialog())
                    {
                        OpenFolder.Filter = "Image Files(*.PNG;*.JPG;*.BMP;*.ICO;*.TIFF)|*.PNG;*.JPG;*.BMP;*.ICO;*.TIFF|All files(*.*)|*.*";

                        if (OpenFolder.ShowDialog() == DialogResult.OK)
                        {
                            SaveImg_btn.Enabled = true;

                            image_directory = OpenFolder.FileName;
                            txtPathFile.Text = image_directory;
                        }
                    }
                }
            }
            else if (Functional_Tab.SelectedTab == Edit_Img_Page)
            {
                OpenFile_btn.Enabled = true;
                
                using (var OpenFile = new OpenFileDialog())
                {
                    OpenFile.Filter = "Image Files(*.JPG)|*.JPG";
                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        SaveImg_btn.Enabled = true;
                        image_directory = OpenFile.FileName;
                        Picture = new Bitmap(image_directory);
                        PictureBox.Image = Picture;
                    }
                }
            }  
        }

        private void SaveImg_btn_Click(object sender, EventArgs e)
        {
            using (var SaveFile = new SaveFileDialog())
            {
                if (Functional_Tab.SelectedTab == Convert_Img_Page)
                {
                    var Extension_selected = ImgExtension.SelectedItem;
                    SaveFile.Filter = $"Image Files(*.{Extension_selected})|*.{Extension_selected.ToString().ToLower()}|All Files(*.*)|*.*";

                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            switch (Extension_selected)
                            {
                                case "PNG":
                                    ImgFormat.ToPng(image_directory, SaveFile.FileName);
                                    break;

                                case "ICO":
                                    break;

                                case "JPG":
                                    ImgFormat.ToJpg(image_directory, SaveFile.FileName);
                                    break;

                                case "BMP":
                                    ImgFormat.ToBmp(image_directory, SaveFile.FileName);
                                    break;

                                case "TIFF":
                                    ImgFormat.ToTiff(image_directory, SaveFile.FileName);
                                    break;
                            }
                            MessageBox.Show("Изображение успешно сконвертировано", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Не удалось сохранить изображение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (Functional_Tab.SelectedTab == Edit_Img_Page)
                {
                    Compress_Image.Compress(image_directory, Compression_ratio_bar.Value);
                }
            }
        }
        //private void OpenFile_Click(object sender, EventArgs e)
        //{
        //OpenFileDialog OpenFile = new OpenFileDialog
        //{
        //    Filter = "Image Files(*.PNG;*.JPG;*.BMP;*.ICO)|*.PNG;*.JPG;*.BMP;*.ICO|All files(*.*)|*.*"
        //};
        //if (OpenFile.ShowDialog() == DialogResult.OK)
        //{
        //    try
        //    {

        //        Picture = new Bitmap(Image.FromFile(OpenFile.FileName));
        //        ImgPath = OpenFile.FileName;
        //        ImgBox.Image = Picture;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Неверный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //if (ImgBox.Image != null && FileExtension.Items.Count == 0)
        //{           
        //    FileExtension.Items.AddRange(extensions);
        //}
        //}

        //private void SaveTo_Click(object sender, EventArgs e)
        //{
        //if (ImgBox.Image != null)
        //{
        //    SaveFileDialog SaveFile = new SaveFileDialog()
        //    {
        //        Title = "Сохранить картинку как",
        //        OverwritePrompt = true,
        //        CheckPathExists = true,
        //        ShowHelp = true,
        //        Filter = $"Image Files(*.{FileExtension.SelectedItem})|*.{(FileExtension.SelectedItem.ToString().ToLower())}"
        //};

        //    if (SaveFile.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            var Extension_value = FileExtension.SelectedItem;
        //            switch (Extension_value)
        //            {
        //                case "PNG":
        //                    ImgBox.Image.Save(SaveFile.FileName, ImageFormat.Png);
        //                    break;

        //                case "JPG":
        //                    ImgBox.Image.Save(SaveFile.FileName, ImageFormat.Jpeg);
        //                    break;

        //                case "BMP":
        //                    ImgBox.Image.Save(SaveFile.FileName, ImageFormat.Bmp);
        //                    break;

        //                case "ICO":
        //                    int res_selectXY;

        //                    foreach (var res in resolutionIcon) //Brute force "16x16", "32x32", "64x64", "128x128", "256x256"
        //                    {
        //                        if (res == ResolutionBox.SelectedItem.ToString() && ResolutionBox.SelectedItem != null)
        //                        {
        //                            if (res.Substring(2, 1) != "x") //if third element of array of resolution != 'x' (128x128 == True)
        //                            {
        //                                res_selectXY = Convert.ToInt16(res.Substring(0, 3)); //Parsing third-digit resolution (input = "128x128" => output = 128)

        //                                using (MagickImage Ico = Image_ConvertTO.Ico(ImgPath, res_selectXY))
        //                                {
        //                                    Ico.Write(SaveFile.FileName);
        //                                }
        //                            }
        //                            else
        //                            {
        //                                res_selectXY = Convert.ToInt16(res.Substring(0, 2)); //Parsing second-digit resolution (input = "64x64" => output = 64)

        //                                using (MagickImage Ico = Image_ConvertTO.Ico(ImgPath, res_selectXY))
        //                                {
        //                                    Ico.Write(SaveFile.FileName);
        //                                }
        //                            }
        //                        }
        //                    }
        //                    break;
        //            }

        //            MessageBox.Show("Успешно сконвертировано!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        //}

        //private void FileExtension_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //if (FileExtension.SelectedItem == "ICO")
        //{
        //    ResolutionPanel.Visible = true;
        //}
        //else
        //{
        //    ResolutionPanel.Visible = false;
        //}
        //}

        //private void CompRatioBar_Scroll(object sender, EventArgs e)
        //{
        //SliderValue.Text = $"Степень сжатия: {CompRatioBar.Value}%";
        //}

        private void SelectMultipleFiles_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectMultipleFiles_radbtn.Checked && Functional_Tab.SelectedTab == Convert_Img_Page)
            {
                txtPathFile.Text = "Директория с вашими изображениями...";
                OpenFile_btn.Enabled = true;
            }
        }

        private void SelectOneFile_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectOneFile_radbtn.Checked && Functional_Tab.SelectedTab == Convert_Img_Page)
            {
                txtPathFile.Text = "Ваше изображение...";
                OpenFile_btn.Enabled = true;
            }

        }

        private void ImgExtension_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ImgExtension.SelectedItem == "ICO")
            {
                ChangeResolutionIcon_Panel.Visible = true;
            }
            else
            {
                ChangeResolutionIcon_Panel.Visible = false;
            }
        }

        private void Compression_ratio_bar_Scroll(object sender, EventArgs e)
        {
            SliderValue.Text = $"Качество\n     {Compression_ratio_bar.Value}%";
        }
    }
}
