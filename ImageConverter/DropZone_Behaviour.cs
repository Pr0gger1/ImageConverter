using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace ImageEditor
{
    public class DropZone_Behaviour : Form
    {
        public string Extension_selected { get; private set; }

        //public InitElements()

        //public void ConvertGo()
        //{
        //    try
        //    {
        //        switch (Extension_selected)
        //        {
        //            case "PNG":
        //                ImgFormat.ToPng(filename, SaveFile.FileName);
        //                break;

        //            case "ICO":
        //                ImgFormat.ToIco(filename, SaveFile.FileName, Convert.ToUInt16(sizeX.SelectedItem));
        //                break;

        //            case "JPG":
        //                ImgFormat.ToJpg(filename, SaveFile.FileName);
        //                break;

        //            case "BMP":
        //                ImgFormat.ToBmp(filename, SaveFile.FileName);
        //                break;

        //            case "TIFF":
        //                ImgFormat.ToTiff(filename, SaveFile.FileName);
        //                break;

        //            case "SVG":
        //                ImgFormat.ToSvg(filename, SaveFile.FileName);
        //                break;
        //        }
        //        Paths.Clear();
        //        txtPathFile.Clear();
        //        MessageBox.Show("Изображение успешно сконвертировано", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Не удалось сохранить изображение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
