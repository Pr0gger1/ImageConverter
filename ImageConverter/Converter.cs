using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace Converter
{
    public class ImgFormat
    {
        public static void ToIco()
        {

        }
        public static void ToPng(string filename, string save_to_dir)
        {
            using (Bitmap picture = new Bitmap(filename))
            {
                picture.Save(save_to_dir, ImageFormat.Png);
            }   
        }
        public static void ToJpg(string filename, string save_to_dir)
        {
            using (Bitmap picture = new Bitmap(filename))
            {
                picture.Save(save_to_dir, ImageFormat.Jpeg);
            } 
        }
        public static void ToBmp(string filename, string save_to_dir)
        {
            using(Bitmap picture = new Bitmap(filename))
            {
                picture.Save(save_to_dir, ImageFormat.Bmp);
            }  
        }
        public static void ToTiff(string filename, string save_to_dir)
        {
            using(Bitmap picture = new Bitmap(filename))
            {
                picture.Save(save_to_dir, ImageFormat.Tiff);
            }  
        }

            
    }

}
