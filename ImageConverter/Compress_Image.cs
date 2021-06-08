using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Compressing
{
    class Compress_Image
    {
        public static void Compress(string filename, int quality)
        {
            int com_ratio = 100 - quality;
            using (Bitmap img = new Bitmap(filename))
            {
                EncoderParameters EncoderImage = new EncoderParameters()
                {
                    Param = new EncoderParameter[]
                    {
                        new EncoderParameter(Encoder.Quality, 100L - com_ratio)
                    }
                };
                img.Save(
                    Path.ChangeExtension(filename, "").Trim('.') + $"img.jpg",
                    ImageCodecInfo.GetImageEncoders()[1],
                    EncoderImage);
            }
        }
    }
}
