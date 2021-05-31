using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ImageMagick;


namespace ImageEdit
{
    public static class Image_ConvertTO
    {
        public static MagickImage Ico(string img, int size)
        {
            MagickImage ico = new MagickImage(img);
            
            ico.Resize(size, size);
            ico.Format = MagickFormat.Ico;

            return ico;
            
        }
        
    }
    public static class Compress_Image
    {
        public static void Compress_img(int compression_ratio, string path_img)
        {
            Bitmap img = new Bitmap(path_img);
            img.Save(
                Path.ChangeExtension(path_img, "").Trim('.') + $"{Path.GetExtension(path_img)}",
                ImageCodecInfo.GetImageEncoders()[1],
                new EncoderParameters()
                {
                    Param = new EncoderParameter[]
                    {
                        new EncoderParameter(Encoder.Quality, 100L - compression_ratio)
                    }
                });
        }
    }
}
