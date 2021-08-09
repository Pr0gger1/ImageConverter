using System;
using ImageMagick;

namespace ImageEditor
{
    public class ImgFormat
    {
        public static void ToIco(string filename, string save_to_dir, ushort size)
        {
            using (MagickImage picture = new MagickImage(filename))
            {
                picture.Resize(size, size);
                picture.Write(save_to_dir + "_converted.ico", MagickFormat.Ico);
            }
        }
        public static void ToPng(string filename, string save_to_dir)
        {
            using (MagickImage picture = new MagickImage(filename))
            {
                picture.Write(save_to_dir + "_converted.png", MagickFormat.Png);
            }
        }
        public static void ToJpg(string filename, string save_to_dir)
        {
            using (MagickImage picture = new MagickImage(filename))
            {
                picture.Write(save_to_dir + "_converted.jpg", MagickFormat.Jpg);
            } 
        }
        public static void ToBmp(string filename, string save_to_dir)
        {
            using(MagickImage picture = new MagickImage(filename))
            {
                picture.Write(save_to_dir + "_converted.bmp", MagickFormat.Bmp);
            }  
        }
        public static void ToTiff(string filename, string save_to_dir)
        {
            using(MagickImage picture = new MagickImage(filename))
            {
                picture.Write(save_to_dir + "_converted.tiff", MagickFormat.Tiff);
            }  
        }
        public static void ToSvg(string filename, string save_to_dir)
        {
            using(MagickImage picture = new MagickImage(filename))
            {
                picture.Write(save_to_dir + "_converted.svg", MagickFormat.Svg);
            }
        }
    }
}
