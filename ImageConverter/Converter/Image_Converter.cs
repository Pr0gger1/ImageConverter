using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ImageMagick;


namespace ImgConvert
{
    public class ConvertImg
    {
        public void ToIco()
        {

        }
        public void ToPng(string filename, string save_to_dir)
        {
            Bitmap picture = new Bitmap(filename);
            picture.Save(save_to_dir, ImageFormat.Png);
        }
    }
    
}
