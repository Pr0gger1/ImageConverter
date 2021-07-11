using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using ImageMagick;

namespace ImageEditor
{
    public partial class ProgramForm : Form
    {
        public List<string> Paths = new List<string>();

        public ProgramForm()
        {
            InitializeComponent();
            
            Compression_ratio_bar.Scroll += Compression_ratio_bar_Scroll;
        }

        private void SaveImg_btn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Converted_Photos"))
            {
                Directory.CreateDirectory($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Converted_Photos");
            }
            if (TabControl.SelectedTab == Convert_Img_Page)
            {
                try
                {
                    string path_to_final_dir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}" + @"\Desktop\Converted_Photos\";
                    foreach (string obj in Paths)
                    {
                        string final_img_path = path_to_final_dir + $"{Path.GetFileNameWithoutExtension(obj)}";

                        switch (ImgExtension.SelectedItem)
                        {
                            case "PNG":
                                ImgFormat.ToPng(obj, final_img_path);
                                break;
                            case "JPG":
                                ImgFormat.ToJpg(obj, final_img_path);
                                break;
                            case "ICO":
                                ImgFormat.ToIco(obj, final_img_path, Convert.ToUInt16(sizeX.SelectedItem));
                                break;
                            case "BMP":
                                ImgFormat.ToBmp(obj, final_img_path);
                                break;
                            case "TIFF":
                                ImgFormat.ToTiff(obj, final_img_path);
                                break;
                            case "SVG":
                                ImgFormat.ToSvg(obj, final_img_path);
                                break;
                        }
                    }
                    MessageBox.Show($"Изображение(я) успешно сконвертировано(ы). Конечные файлы находятся в папке: {path_to_final_dir}", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception error)
                {
                    MessageBox.Show($"К сожалению, не удалось сохранить изображение\nОшибка:\n{error}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (!Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Compressed_Photos"))
                {
                    Directory.CreateDirectory($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Compressed_Photos");
                }
                foreach (string obj in Paths)
                {

                }

            }
           
            
            txtPathFile.Clear();
            Paths.Clear();
            SaveImg_btn.Enabled = false;
            ClearDropZone_btn.Enabled = false;
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
            SliderValue.Text = $"Качество\n\r{Compression_ratio_bar.Value}%";
        }

        private void DropZone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                TitleDrop.Text = "Отпустите кнопку мыши";
                TitleDrop2.Text = "Отпустите кнопку мыши";
            }
        }

        private void DropZone_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string obj in data)
            {
                if (Directory.Exists(obj))
                {
                    Paths.AddRange(Directory.GetFiles(obj));
                }
                else
                {
                    Paths.Add(obj);
                }
            }
            SaveImg_btn.Enabled = true;
            ClearDropZone_btn.Enabled = true;

            if (TabControl.SelectedTab == Convert_Img_Page)
            {
                txtPathFile.Text += String.Join("\n\r", Paths);
            }
        }

        private void DropZone_DragLeave(object sender, EventArgs e)
        {
            TitleDrop.Text = "Перетащите файл(ы) в эту область...";
            TitleDrop2.Text = "Перетащите файл(ы) в эту область...";
        }

        private void ClearDropZone_btn_Click(object sender, EventArgs e)
        {
            Paths.Clear();
            txtPathFile.Clear();
            SaveImg_btn.Enabled = false;
            ClearDropZone_btn.Enabled = false;
        }

        private void ProgramForm_Load(object sender, EventArgs e)
        {
            ImgExtension.SelectedItem = Properties.Settings.Default.ConvertToExt;
            sizeX.SelectedItem = Properties.Settings.Default.ResolutionIcon;
        }

        private void ProgramForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ConvertToExt = ImgExtension.SelectedItem.ToString();
            Properties.Settings.Default.ResolutionIcon = Convert.ToUInt16(sizeX.SelectedItem);
            Properties.Settings.Default.Save();
        }
    }
}